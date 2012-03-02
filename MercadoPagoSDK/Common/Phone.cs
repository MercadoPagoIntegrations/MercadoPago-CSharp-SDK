﻿/*
 * Copyright 2011 MercadoLibre, Inc.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License"); you may
 * not use this file except in compliance with the License. You may obtain
 * a copy of the License at
 * 
 *  http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS, WITHOUT
 * WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the
 * License for the specific language governing permissions and limitations
 * under the License.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MercadoPagoSDK
{
    /// <summary>
    /// A representation of the phone resource. 
    /// </summary>
    public class Phone
    {
        /// <summary>
        /// The phone as a json.
        /// </summary>
        private JSONObject _json;

        /// <summary>
        /// Create a new phone instance with empty values.
        /// </summary>
        public Phone()
        {
            string json = "{}";

            _json = JSONObject.CreateFromString(json);
        }

        /// <summary>
        /// Create a new phone instance using a valid json.
        /// </summary>
        /// <param name="json">The json object used to
        /// fill the phone data</param>
        public Phone(JSONObject json)
        {
            // todo: como valido que no me asignen cualquier fruta
            _json = json;
        }

        /// <summary>
        /// Area Code field.
        /// </summary>
        public String AreaCode
        {
            get
            {
                return _json.GetJSONStringAttribute("area_code");
            }
            set
            {
                _json.SetJSONStringAttribute("area_code", value);
            }
        }

        /// <summary>
        /// Extension field.
        /// </summary>
        public String Extension
        {
            get
            {
                return _json.GetJSONStringAttribute("extension");
            }
            set
            {
                _json.SetJSONStringAttribute("extension", value);
            }
        }

        /// <summary>
        /// Number field.
        /// </summary>
        public String Number
        {
            get
            {
                return _json.GetJSONStringAttribute("number");
            }
            set
            {
                _json.SetJSONStringAttribute("number", value);
            }
        }

        /// <summary>
        /// Returns the phone as a json object.
        /// </summary>
        public JSONObject ToJSON()
        {
            return _json;
        }
    }
}