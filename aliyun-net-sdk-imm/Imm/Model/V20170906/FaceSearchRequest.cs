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
using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.imm.Transform;
using Aliyun.Acs.imm.Transform.V20170906;
using System.Collections.Generic;

namespace Aliyun.Acs.imm.Model.V20170906
{
    public class FaceSearchRequest : RpcAcsRequest<FaceSearchResponse>
    {
        public FaceSearchRequest()
            : base("imm", "2017-09-06", "FaceSearch", "imm", "openAPI")
        {
        }

		private int? resultNum;

		private string action;

		private string project;

		private string searchThresholdLevel;

		private string srcUri;

		private bool? isThreshold;

		private string groupName;

		private string accessKeyId;

		public int? ResultNum
		{
			get
			{
				return resultNum;
			}
			set	
			{
				resultNum = value;
				DictionaryUtil.Add(QueryParameters, "ResultNum", value.ToString());
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

		public string SearchThresholdLevel
		{
			get
			{
				return searchThresholdLevel;
			}
			set	
			{
				searchThresholdLevel = value;
				DictionaryUtil.Add(QueryParameters, "SearchThresholdLevel", value);
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

		public bool? IsThreshold
		{
			get
			{
				return isThreshold;
			}
			set	
			{
				isThreshold = value;
				DictionaryUtil.Add(QueryParameters, "IsThreshold", value.ToString());
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

        public override FaceSearchResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return FaceSearchResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}