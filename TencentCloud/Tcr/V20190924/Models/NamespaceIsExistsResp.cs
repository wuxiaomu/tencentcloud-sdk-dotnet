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

namespace TencentCloud.Tcr.V20190924.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class NamespaceIsExistsResp : AbstractModel
    {
        
        /// <summary>
        /// 命名空间是否存在
        /// </summary>
        [JsonProperty("IsExist")]
        public bool? IsExist{ get; set; }

        /// <summary>
        /// 是否为保留命名空间
        /// </summary>
        [JsonProperty("IsPreserved")]
        public bool? IsPreserved{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IsExist", this.IsExist);
            this.SetParamSimple(map, prefix + "IsPreserved", this.IsPreserved);
        }
    }
}
