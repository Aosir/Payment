using System;
using Newtonsoft.Json;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SceneMarketingContent Data Structure.
    /// </summary>
    [Serializable]
    public class SceneMarketingContent : AlipayObject
    {
        /// <summary>
        /// 小图标地址
        /// </summary>
        [JsonProperty("icon")]
        [XmlElement("icon")]
        public string Icon { get; set; }

        /// <summary>
        /// 营销图片地址
        /// </summary>
        [JsonProperty("image")]
        [XmlElement("image")]
        public string Image { get; set; }

        /// <summary>
        /// 营销内容意义
        /// </summary>
        [JsonProperty("meaning")]
        [XmlElement("meaning")]
        public string Meaning { get; set; }

        /// <summary>
        /// 营销内容标签
        /// </summary>
        [JsonProperty("tags")]
        [XmlArray("tags")]
        [XmlArrayItem("string")]
        public List<string> Tags { get; set; }

        /// <summary>
        /// 限制及特性描述
        /// </summary>
        [JsonProperty("tips")]
        [XmlArray("tips")]
        [XmlArrayItem("string")]
        public List<string> Tips { get; set; }

        /// <summary>
        /// 营销内容标题
        /// </summary>
        [JsonProperty("title")]
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 营销内容类型
        /// </summary>
        [JsonProperty("type")]
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 营销内容跳转地址
        /// </summary>
        [JsonProperty("url")]
        [XmlElement("url")]
        public string Url { get; set; }
    }
}