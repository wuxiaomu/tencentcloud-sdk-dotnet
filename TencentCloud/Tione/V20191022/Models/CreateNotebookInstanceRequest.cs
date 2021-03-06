/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Tione.V20191022.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateNotebookInstanceRequest : AbstractModel
    {
        
        /// <summary>
        /// Notebook实例名称
        /// </summary>
        [JsonProperty("NotebookInstanceName")]
        public string NotebookInstanceName{ get; set; }

        /// <summary>
        /// Notebook算力类型
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// 角色的资源描述
        /// </summary>
        [JsonProperty("RoleArn")]
        public string RoleArn{ get; set; }

        /// <summary>
        /// 外网访问权限，可取值Enabled/Disabled
        /// </summary>
        [JsonProperty("DirectInternetAccess")]
        public string DirectInternetAccess{ get; set; }

        /// <summary>
        /// Root用户权限，可取值Enabled/Disabled
        /// </summary>
        [JsonProperty("RootAccess")]
        public string RootAccess{ get; set; }

        /// <summary>
        /// 安全组ID
        /// </summary>
        [JsonProperty("SecurityGroupIds")]
        public string[] SecurityGroupIds{ get; set; }

        /// <summary>
        /// 子网ID
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// 数据卷大小(GB)
        /// </summary>
        [JsonProperty("VolumeSizeInGB")]
        public ulong? VolumeSizeInGB{ get; set; }

        /// <summary>
        /// Notebook标签
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NotebookInstanceName", this.NotebookInstanceName);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "RoleArn", this.RoleArn);
            this.SetParamSimple(map, prefix + "DirectInternetAccess", this.DirectInternetAccess);
            this.SetParamSimple(map, prefix + "RootAccess", this.RootAccess);
            this.SetParamArraySimple(map, prefix + "SecurityGroupIds.", this.SecurityGroupIds);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "VolumeSizeInGB", this.VolumeSizeInGB);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
        }
    }
}

