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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.CloudAPI.Model.V20160714;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.CloudAPI.Transform.V20160714
{
    public class DescribeCatalogResponseUnmarshaller
    {
        public static DescribeCatalogResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeCatalogResponse describeCatalogResponse = new DescribeCatalogResponse();

			describeCatalogResponse.HttpResponse = context.HttpResponse;
			describeCatalogResponse.RequestId = context.StringValue("DescribeCatalog.RequestId");
			describeCatalogResponse.CatalogId = context.StringValue("DescribeCatalog.CatalogId");
			describeCatalogResponse.CatalogName = context.StringValue("DescribeCatalog.CatalogName");
			describeCatalogResponse.Description = context.StringValue("DescribeCatalog.Description");
			describeCatalogResponse.ParentId = context.StringValue("DescribeCatalog.ParentId");
			describeCatalogResponse.CreatedTime = context.StringValue("DescribeCatalog.CreatedTime");
			describeCatalogResponse.ModifiedTime = context.StringValue("DescribeCatalog.ModifiedTime");
			describeCatalogResponse.RegionId = context.StringValue("DescribeCatalog.RegionId");

			List<string> describeCatalogResponse_apiIds = new List<string>();
			for (int i = 0; i < context.Length("DescribeCatalog.ApiIds.Length"); i++) {
				describeCatalogResponse_apiIds.Add(context.StringValue("DescribeCatalog.ApiIds["+ i +"]"));
			}
			describeCatalogResponse.ApiIds = describeCatalogResponse_apiIds;
        
			return describeCatalogResponse;
        }
    }
}