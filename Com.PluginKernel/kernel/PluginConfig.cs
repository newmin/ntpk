﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Com.PluginKernel
{
    public class PluginConfig
    {
        /// <summary>
        /// 插件目录名称,以"/"结尾
        /// </summary>
        public static string PLUGIN_DIRECTORY = "plugins/";

        /// <summary>
        /// 插件临时文件存放目录,以"/"结尾。用于存放日志，临时文件等
        /// </summary>
        public static string PLUGIN_TMP_DIRECTORY = "plugins/";

        /// <summary>
        /// 插件日志是否打开,默认为关闭
        /// </summary>
        public static bool PLUGIN_LOG_OPENED = false;

        /// <summary>
        /// 插件异常日志格式,默认为：<{time}>:{message}\r\nSource:{source}\r\nAddress:{addr}\r\nStack:{stack}\r\n\r\n
        /// </summary>
        public static string PLUGIN_LOG_EXCEPT_FORMAT = "** {time} **:{message}\r\nSource:{source}\r\nAddress:{addr}\r\nStack:{stack}\r\n\r\n";

    }
}
