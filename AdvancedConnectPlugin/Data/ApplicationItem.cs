﻿/*
Copyright 2016 TGW Software Services GmbH

Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance 
with the License. You may obtain a copy of the License at

http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software distributed under the License is 
distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. 
See the License for the specific language governing permissions and limitations under the License.
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedConnectPlugin.Data
{
    [Serializable()]
    public class ApplicationItem
    {
        public String name { get; set; }
        public String method { get; set; }
        public String path { get; set; }
        public String options { get; set; }
        public Boolean enable { get; set; }

        public ApplicationItem()
        {
        }
        public ApplicationItem(String name, String method, String path, String options, Boolean enable)
        {
            this.name = name;
            this.method = method;
            this.path = path;
            this.options = options;
            this.enable = enable;
        }

    }
    
}
