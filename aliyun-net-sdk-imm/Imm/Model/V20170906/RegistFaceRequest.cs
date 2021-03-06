/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
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
using System.Collections.Generic;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.imm.Transform;
using Aliyun.Acs.imm.Transform.V20170906;

namespace Aliyun.Acs.imm.Model.V20170906
{
    public class RegistFaceRequest : RpcAcsRequest<RegistFaceResponse>
    {
        public RegistFaceRequest()
            : base("imm", "2017-09-06", "RegistFace", "imm", "openAPI")
        {
        }

		private bool? chooseBiggestFace;

		private bool? isQualityLimit;

		private string action;

		private string project;

		private string srcUri;

		private string registerCheckLevel;

		private string groupName;

		private string user;

		private string accessKeyId;

		public bool? ChooseBiggestFace
		{
			get
			{
				return chooseBiggestFace;
			}
			set	
			{
				chooseBiggestFace = value;
				DictionaryUtil.Add(QueryParameters, "ChooseBiggestFace", value.ToString());
			}
		}

		public bool? IsQualityLimit
		{
			get
			{
				return isQualityLimit;
			}
			set	
			{
				isQualityLimit = value;
				DictionaryUtil.Add(QueryParameters, "IsQualityLimit", value.ToString());
			}
		}

		public string Action
		{
			get
			{
				return action;
			}
			set	
			{
				action = value;
				DictionaryUtil.Add(QueryParameters, "Action", value);
			}
		}

		public string Project
		{
			get
			{
				return project;
			}
			set	
			{
				project = value;
				DictionaryUtil.Add(QueryParameters, "Project", value);
			}
		}

		public string SrcUri
		{
			get
			{
				return srcUri;
			}
			set	
			{
				srcUri = value;
				DictionaryUtil.Add(QueryParameters, "SrcUri", value);
			}
		}

		public string RegisterCheckLevel
		{
			get
			{
				return registerCheckLevel;
			}
			set	
			{
				registerCheckLevel = value;
				DictionaryUtil.Add(QueryParameters, "RegisterCheckLevel", value);
			}
		}

		public string GroupName
		{
			get
			{
				return groupName;
			}
			set	
			{
				groupName = value;
				DictionaryUtil.Add(QueryParameters, "GroupName", value);
			}
		}

		public string User
		{
			get
			{
				return user;
			}
			set	
			{
				user = value;
				DictionaryUtil.Add(QueryParameters, "User", value);
			}
		}

		public string AccessKeyId
		{
			get
			{
				return accessKeyId;
			}
			set	
			{
				accessKeyId = value;
				DictionaryUtil.Add(QueryParameters, "AccessKeyId", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override RegistFaceResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return RegistFaceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
