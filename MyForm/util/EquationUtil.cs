/**
* 命名空间: MyForm
*
* 功 能： N/A
* 类 名： EquationUtil
* 创建人：Administrator
* 创建时间：2017/7/6 10:24:09
* CLR VERSION: 4.0.30319.42000
* Ver 变更日期 负责人 变更内容
* ───────────────────────────────────
* V0.01 2017/7/6 10:24:09 Administrator 初版
*
* Copyright (c) 2017 Lir Corporation. All rights reserved.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyForm.util
{
    class EquationUtil
    {
        /// <summary>
        /// 对外接口方法
        /// 对算式进行计算，返回结果
        /// </summary>
        /// <param name="equation"></param>
        /// <returns></returns>
        public static string ComputeEquation(string equation)
        {
            string result = "0";
            try
            {
                if (!string.IsNullOrEmpty(equation))
                {
                    char[] chs = equation.ToCharArray();
                    Stack<EquationNode> equationNodeStack = new Stack<EquationNode>();
                    int chscount = chs.Count();
                    for (int i = 0; i < chscount; i++)
                    {
                        char ch = chs[i];
                        switch (ch)
                        {
                            case '0':
                            case '1':
                            case '2':
                            case '3':
                            case '4':
                            case '5':
                            case '6':
                            case '7':
                            case '8':
                            case '9':
                            case '.':
                                addNumNode(equationNodeStack, ch);
                                break;
                            case '-':
                            case '+':
                            case '*':
                            case '/':
                                addOperationNode(equationNodeStack, ch);
                                break;
                            case '(':
                                addLeftNode(equationNodeStack);
                                break;
                            case ')':
                                compute(equationNodeStack);
                                break;
                            default:
                                break;
                        }
                    }
                    while (equationNodeStack.Count > 1)
                    {
                        compute(equationNodeStack);
                    }
                    if (equationNodeStack.Any())
                    {
                        result = equationNodeStack.Pop().value;
                    }
                }
            }
            catch (Exception e)
            {
                result = e.Message;
            }
            
            return result;
        }
        /// <summary>
        /// 单个子算式计算
        /// 括号内部计算
        /// </summary>
        /// <param name="equationNodeStack"></param>
        private static void compute(Stack<EquationNode> equationNodeStack)
        {
            if (equationNodeStack.Any())
            {
                Stack<EquationNode> equationNodeStack1 = new Stack<EquationNode>();
                EquationNode item;
                //获取子算式
                while (equationNodeStack.Any())
                {
                    item = equationNodeStack.Pop();
                    if(item.type == EquationNodeType.LEFT)
                    {
                        break;
                    }
                    equationNodeStack1.Push(item);
                }
                //解决第一个数字为负数的情况，前面添加一个0，变成减法
                if (equationNodeStack1.Any())
                {
                    item = equationNodeStack1.First();
                    if (item.type == EquationNodeType.OPERATION && string.Equals(item.value, "-"))
                    {
                        item = new EquationNode(EquationNodeType.NUM, '0');
                        equationNodeStack1.Push(item);
                    }
                }
                //处理乘除法运算
                Stack <EquationNode> equationNodeStack2 = new Stack<EquationNode>();
                while (equationNodeStack1.Any())
                {
                    item = equationNodeStack1.Pop();
                    if(item.type == EquationNodeType.OPERATION)
                    {
                        if(string.Equals(item.value, "*")|| string.Equals(item.value, "/"))
                        {
                            EquationNode item1 = equationNodeStack1.Pop();
                            EquationNode item2 = equationNodeStack2.Pop();
                            string r1 = operCompute(item2.value, item1.value, item.value);
                            item = new EquationNode(EquationNodeType.NUM, r1);
                        }
                    }
                    equationNodeStack2.Push(item);
                }
                while (equationNodeStack2.Count>1)
                {
                    //还原栈
                    while (equationNodeStack2.Any())
                    {
                        item = equationNodeStack2.Pop();
                        equationNodeStack1.Push(item);
                    }
                    //运算
                    while (equationNodeStack1.Any())
                    {
                        item = equationNodeStack1.Pop();
                        if (item.type == EquationNodeType.OPERATION)
                        {
                            EquationNode item1 = equationNodeStack1.Pop();
                            EquationNode item2 = equationNodeStack2.Pop();
                            string r1 = operCompute(item2.value, item1.value, item.value);
                            item = new EquationNode(EquationNodeType.NUM, r1);
                        }
                        equationNodeStack2.Push(item);
                    }
                }
                if (equationNodeStack2.Any())
                {
                    item = equationNodeStack2.Pop();
                    equationNodeStack.Push(item);
                }
            }
        }

        /// <summary>
        /// 节点值计算
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <param name="operation"></param>
        /// <returns></returns>
        public static string operCompute(string s1,string s2,string operation)
        {
            string result = "0";
            if (s1.Contains(".") || s2.Contains("."))
            {
                result = operComputeDouble(double.Parse(s1), double.Parse(s2), operation);
            }
            else
            {
                result = operComputeLong(long.Parse(s1), long.Parse(s2), operation);
            }
            return result;
        }
        /// <summary>
        /// 长整型计算
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <param name="operation"></param>
        /// <returns></returns>
        private static  string operComputeLong(long s1, long s2, string operation)
        {
            long result = 0;

            if (operation.Equals("*"))
            {
                result = s1 * s2;
            }
            else if (operation.Equals("/"))
            {
                result = s1 / s2;
            }
            else if (operation.Equals("+"))
            {
                result = s1 + s2;
            }
            else if (operation.Equals("-"))
            {
                result = s1 - s2;
            }
            return result.ToString();
        }
        /// <summary>
        /// 浮点数计算
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <param name="operation"></param>
        /// <returns></returns>
        private static string operComputeDouble(double s1, double s2, string operation)
        {
            double result = 0;

            if (operation.Equals("*"))
            {
                result = s1 * s2;
            }
            else if (operation.Equals("/"))
            {
                result = s1 / s2;
            }
            else if (operation.Equals("+"))
            {
                result = s1 + s2;
            }
            else if (operation.Equals("-"))
            {
                result = s1 - s2;
            }
            return result.ToString();
        }
        /// <summary>
        /// 添加数字节点
        /// 如果前一个节点是数字，那么将字符拼接到前一个节点值
        /// 否则新增一个节点
        /// </summary>
        /// <param name="equationNodeStack"></param>
        /// <param name="ch"></param>
        private static void addNumNode(Stack<EquationNode> equationNodeStack,char ch)
        {
            if (equationNodeStack.Any())
            {
                EquationNode item = equationNodeStack.Pop();
                if (item.type == EquationNodeType.NUM)
                {
                    item.concat(ch);
                    equationNodeStack.Push(item);
                }
                else
                {
                    equationNodeStack.Push(item);
                    item = new EquationNode(EquationNodeType.NUM, ch);
                    equationNodeStack.Push(item);
                }
            }
            else
            {
                EquationNode item = new EquationNode(EquationNodeType.NUM, ch);
                equationNodeStack.Push(item);
            }
        }
        /// <summary>
        /// 添加操作符节点
        /// </summary>
        /// <param name="equationNodeStack"></param>
        /// <param name="ch"></param>
        private static void addOperationNode(Stack<EquationNode> equationNodeStack, char ch)
        {
            EquationNode item = new EquationNode(EquationNodeType.OPERATION, ch);
            equationNodeStack.Push(item);
        }
        /// <summary>
        /// 添加左括号节点
        /// </summary>
        /// <param name="equationNodeStack"></param>
        private static void addLeftNode(Stack<EquationNode> equationNodeStack)
        {
            EquationNode item = new EquationNode(EquationNodeType.LEFT, '(');
            equationNodeStack.Push(item);
        }
    }
    /// <summary>
    /// 节点类型
    /// </summary>
    enum EquationNodeType
    {
        LEFT,
        NUM,
        RIGHT,
        OPERATION
    }
    /// <summary>
    /// 节点类
    /// </summary>
    class EquationNode
    {
        public EquationNodeType type;
        public string value;
        public EquationNode(EquationNodeType type,string value)
        {
            this.type = type;
            this.value = value;
        }
        public EquationNode(EquationNodeType type, char ch)
        {
            this.type = type;
            this.value = ch.ToString();
        }
        public EquationNode(EquationNodeType type)
        {
            this.type = type;
        }

        public void concat(char ch)
        {
            this.value = string.Concat(this.value, ch);
        }
    }
}
