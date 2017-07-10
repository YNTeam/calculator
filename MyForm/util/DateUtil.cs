/**
* 命名空间: MyForm.util
*
* 功 能： N/A
* 类 名： DateUtil
* 创建人：Administrator
* 创建时间：2017/7/6 14:16:41
* CLR VERSION: 4.0.30319.42000
* Ver 变更日期 负责人 变更内容
* ───────────────────────────────────
* V0.01 2017/7/6 14:16:41 Administrator 初版
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
    public class DateUtil
    {
        /*时间格式字符串说明****************************************
        * 自定义：
        * yy		年份后两位
        * yyyy	4位年份
        * MM		两位月份；单数月份前面用0填充
        * dd		日数
        * ddd		周几
        * dddd	星期几
        * hh		12小时制的小时数
        * HH		24小时制的小时数
        * mm		分钟数
        * ss		秒数
        * ff		毫秒数前2位
        * fff		毫秒数前3位
        * ffff	毫秒数前4位
        * 分隔符	可使用分隔符来分隔年月日时分秒。包含的值可为：-、/、:等非关键字符
        *（例：yyyy-MM-dd HH:mm:ss:ffff dddd  => 2016/05/09 13:09:55:2350 星期一）
        * 制式：
        * 符号　示例(2016-05-09 13:09:55:2350)	格式说明
        * d		2016/5/9						短日期
        * D		2016年5月9日					长日期
        * f		2016年5月9日 13:09				长日期 短时间
        * F		2016年5月9日 13:09:55			长日期 长时间
        * g		2016/5/9 13:09					短日期 短时间
        * G		2016/5/9 13:09:55				短日期 长时间
        * t		13:09							短时间
        * T		13:09:55						长时间
        * u		2016-05-09 13:09:55Z	 
        * U		2016年5月9日 5:09:55			本初子午线的长日期和长时间
        * m		5月9日	 
        * M		5月9日	 
        * r		Mon, 09 May 2016 13:09:55 GMT	 
        * R		Mon, 09 May 2016 13:09:55 GMT	 
        * y		2016年5月	 
        * Y		2016年5月	 
        * o		2016-05-09T13:09:55.2350000	 
        * O		2016-05-09T13:09:55.2350000	 
        * s		2016-05-09T13:09:55
        **************************************************************/
        public const string DEFAULT_DATE_STR_FORMAT = "yyyy-MM-dd";
        public const string DEFAULT_TIME_STR_FORMAT = "yyyy-MM-dd HH:mm:ss";

        public enum TimeStampEnum
        {
            MILLISECOND,
            SECOND,
            MINUTE,
            HOUR,
            DAY,
            WEEK,
            MONTH,
            YEAR
        }

        /************************************
         * Method:    getCurrentDateTimeStr
         * FullName:  MyForm.util.DateUtil.getCurrentDateTimeStr
         * Returns:   string
         * CreateTime: 2017/07/06 16:22
         * Description: 获取默认格式的当前时间字符串
         ************************************/
        public static string getCurrentDateTimeStr()
        {
            return getDateTimeStr(DateTime.Now,DEFAULT_TIME_STR_FORMAT);
        }
        /************************************
         * Method:    getCurrentDateStr
         * FullName:  MyForm.util.DateUtil.getCurrentDateStr
         * Returns:   string
         * CreateTime: 2017/07/06 16:35
         * Description: 获取默认格式的当前日期字符串
         ************************************/
        public static string getCurrentDateStr()
        {
            return getDateTimeStr(DateTime.Now, DEFAULT_DATE_STR_FORMAT);
        }
        /************************************
         * Method:    getCurrentDateTimeStr
         * FullName:  MyForm.util.DateUtil.getCurrentDateTimeStr
         * Returns:   string
         * CreateTime: 2017/07/06 16:22
         * Parameter: string format
         * Description: 获取要求格式的当前时间字符串
         ************************************/
        public static string getCurrentDateTimeStr(string format)
        {
            return getDateTimeStr(DateTime.Now, format);
        }
        /************************************
         * Method:    getDateTimeStr
         * FullName:  MyForm.util.DateUtil.getDateTimeStr
         * Returns:   string
         * CreateTime: 2017/07/06 16:23
         * Parameter: DateTime dateTime
         * Description: 获取默认格式的时间字符串
         ************************************/
         public static string getDateTimeStr(DateTime dateTime)
        {
            return getDateTimeStr(dateTime,DEFAULT_TIME_STR_FORMAT);
        }
        /************************************
         * Method:    getDateTimeStr
         * FullName:  MyForm.util.DateUtil.getDateTimeStr
         * Returns:   string
         * CreateTime: 2017/07/06 16:23
         * Parameter: DateTime dateTime
         * Description: 获取默认格式的日期字符串
         ************************************/
        public static string getDateStr(DateTime date)
        {
            return getDateTimeStr(date, DEFAULT_DATE_STR_FORMAT);
        }

        /************************************
         * Method:    getDateTimeStr
         * FullName:  MyForm.util.DateUtil.getDateTimeStr
         * Returns:   string
         * CreateTime: 2017/07/06 16:24
         * Parameter: DateTime dateTime
         * Parameter: string format
         * Description: 获取规定格式的时间字符串
         ************************************/
        public static string getDateTimeStr(DateTime dateTime,string format)
        {
            if (dateTime == null) dateTime = DateTime.Now;
            return dateTime.ToString(format);
        }

        /************************************
         * Method:    getDateTime
         * FullName:  MyForm.util.DateUtil.getDateTime
         * Returns:   System.DateTime
         * CreateTime: 2017/07/06 16:04
         * Parameter: long timeStamp
         * Description: 将时间轴（秒S为单位）转换为DateTime
         ************************************/
        public static DateTime getDateTime(long timeStamp)
        {
            DateTime dateTime = TimeZone.CurrentTimeZone.ToLocalTime(new System.DateTime(1970, 1, 1));
            dateTime.AddSeconds(timeStamp);
            return dateTime;
        }

        /************************************
         * Method:    getDateTime
         * FullName:  MyForm.util.DateUtil.getDateTime
         * Returns:   System.DateTime
         * CreateTime: 2017/07/06 16:09
         * Parameter: string dateTimeStr
         * Description: 将时间字符串转为DateTime
         ************************************/
        public static DateTime getDateTime(string dateTimeStr)
        {
            return DateTime.Parse(dateTimeStr);
        }

        /************************************
         * Method:    changeDateTimeFormat
         * FullName:  MyForm.util.DateUtil.changeDateTimeFormat
         * Returns:   string
         * CreateTime: 2017/07/06 16:20
         * Parameter: string dateTimeStr
         * Description: 修改实际格式，返回默认格式的时间字符串
         ************************************/
         public static string changeDateTimeFormat(string dateTimeStr)
        {
            return changeDateTimeFormat(dateTimeStr, DEFAULT_TIME_STR_FORMAT);
        }
        /************************************
         * Method:    changeDateTimeFormat
         * FullName:  MyForm.util.DateUtil.changeDateTimeFormat
         * Returns:   string
         * CreateTime: 2017/07/06 16:20
         * Parameter: string dateTimeStr
         * Description: 修改实际格式，返回默认格式的日期字符串
         ************************************/
        public static string changeDateFormat(string dateStr)
        {
            return changeDateTimeFormat(dateStr, DEFAULT_DATE_STR_FORMAT);
        }
        /************************************
         * Method:    changeDateTimeFormat
         * FullName:  MyForm.util.DateUtil.changeDateTimeFormat
         * Returns:   string
         * CreateTime: 2017/07/06 16:21
         * Parameter: string dateTimeStr
         * Parameter: string format
         * Description: 修改日期格式，返回新格式的日期字符串
         ************************************/
        public static string changeDateTimeFormat(string dateTimeStr,string format)
        {
            DateTime dateTime = getDateTime(dateTimeStr);
            return getDateTimeStr(dateTime, format);
        }
        /************************************
         * Method:    getDaysBetweenDateTimes
         * FullName:  MyForm.util.DateUtil.getDaysBetweenDateTimes
         * Returns:   int
         * CreateTime: 2017/07/06 16:51
         * Parameter: DateTime newDateTime
         * Parameter: DateTime oldDateTime
         * Description: 获取两个日期时间的间隔天数
         ************************************/
         public static int getDaysBetweenDateTimes(DateTime newDateTime, DateTime oldDateTime)
        {
            TimeSpan timeSpan = newDateTime.Subtract(oldDateTime);
            double days = timeSpan.TotalDays;
            return (int)Math.Floor(days);
        }
        /************************************
         * Method:    getDaysBetweenDateTimeStrs
         * FullName:  MyForm.util.DateUtil.getDaysBetweenDateTimeStrs
         * Returns:   int
         * CreateTime: 2017/07/06 16:55
         * Parameter: string newDateTimeStr
         * Parameter: string oldDateTimeStr
         * Description: 获取两个日期时间的间隔天数
         ************************************/
        public static int getDaysBetweenDateTimeStrs(string newDateTimeStr, string oldDateTimeStr)
        {
            return getDaysBetweenDateTimes(getDateTime(newDateTimeStr), getDateTime(oldDateTimeStr));
        }
        /************************************
         * Method:    getDaysBetweenDateTimeStrs
         * FullName:  MyForm.util.DateUtil.getDaysBetweenDateTimeStrs
         * Returns:   int
         * CreateTime: 2017/07/06 16:55
         * Parameter: string oldDateTimeStr
         * Description: 过去时间到当前时间的天数
         ************************************/
        public static int getDaysSinceDateTimeStr(string oldDateTimeStr)
        {
            return getDaysBetweenDateTimes(DateTime.Now, getDateTime(oldDateTimeStr));
        }
        /************************************
         * Method:    getCountBetweenDateTimes
         * FullName:  MyForm.util.DateUtil.getCountBetweenDateTimes
         * Returns:   long
         * CreateTime: 2017/07/07 8:59
         * Parameter: DateTime newDateTime
         * Parameter: DateTime oldDateTime
         * Parameter: TimeStampEnum timeStampEnum
         * Description: 根据参数获取两个日期时间的特定维度的差值
         ************************************/
         public static long getCountBetweenDateTimes(DateTime newDateTime, DateTime oldDateTime,TimeStampEnum timeStampEnum)
        {
            TimeSpan timeSpan = newDateTime.Subtract(oldDateTime);
            if (timeStampEnum == TimeStampEnum.MILLISECOND)
            {
                return (long)Math.Floor(timeSpan.TotalMilliseconds);
            }
            else if (timeStampEnum == TimeStampEnum.SECOND)
            {
                return (long)Math.Floor(timeSpan.TotalSeconds);
            }
            else if (timeStampEnum == TimeStampEnum.MINUTE)
            {
                return (long)Math.Floor(timeSpan.TotalMinutes);
            }
            else if(timeStampEnum == TimeStampEnum.HOUR)
            {
                return (long)Math.Floor(timeSpan.TotalHours);
            }
            else if (timeStampEnum == TimeStampEnum.DAY)
            {
                return (long)Math.Floor(timeSpan.TotalDays);
            }
            else if (timeStampEnum == TimeStampEnum.WEEK)
            {
                return (long)Math.Floor(timeSpan.TotalDays/7);
            }
            else if(timeStampEnum == TimeStampEnum.MONTH)
            {
                long result = (newDateTime.Year - oldDateTime.Year) * 12 + (newDateTime.Month - oldDateTime.Month);
                return result;
            }
            else if(timeStampEnum == TimeStampEnum.YEAR)
            {
                return newDateTime.Year - oldDateTime.Year;
            }
            return 0;
        }
        /************************************
         * Method:    getCountBetweenDateTimes
         * FullName:  MyForm.util.DateUtil.getCountBetweenDateTimes
         * Returns:   long
         * CreateTime: 2017/07/07 9:02
         * Parameter: string newDateTimeStr
         * Parameter: string oldDateTimeStr
         * Parameter: TimeStampEnum timeStampEnum
         * Description: 根据参数获取两个日期时间的特定维度的差值
         ************************************/
        public static long getCountBetweenDateTimes(string newDateTimeStr, string oldDateTimeStr, TimeStampEnum timeStampEnum)
        {
            return getCountBetweenDateTimes(getDateTime(newDateTimeStr), getDateTime(oldDateTimeStr), timeStampEnum);
        }
        /************************************
         * Method:    getCountBetweenDateTimes
         * FullName:  MyForm.util.DateUtil.getCountBetweenDateTimes
         * Returns:   long
         * CreateTime: 2017/07/07 9:02
         * Parameter: string oldDateTimeStr
         * Parameter: TimeStampEnum timeStampEnum
         * Description: 根据参数获取日期时间到当前时间的特定维度的差值
         ************************************/
        public static long getCountBetweenDateTimes(string oldDateTimeStr, TimeStampEnum timeStampEnum)
        {
            return getCountBetweenDateTimes(DateTime.Now, getDateTime(oldDateTimeStr), timeStampEnum);
        }
        /************************************
         * Method:    getDaysFromSeconds
         * FullName:  MyForm.util.DateUtil.getDaysFromSeconds
         * Returns:   double
         * CreateTime: 2017/07/06 17:08
         * Parameter: int seconds
         * Description: 将秒转换成天数
         ************************************/
        public static double getDaysFromSeconds(int seconds)
        {
            TimeSpan timeSpan = TimeSpan.FromSeconds(seconds);
            return timeSpan.TotalDays;
        }
    }
}
