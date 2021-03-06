/******************************************************************************* 
 *  Copyright 2008 Amazon Technologies, Inc.
 *  Licensed under the Apache License, Version 2.0 (the "License"); 
 *  
 *  You may not use this file except in compliance with the License. 
 *  You may obtain a copy of the License at: http://aws.amazon.com/apache2.0
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the 
 *  specific language governing permissions and limitations under the License.
 * ***************************************************************************** 
 *    __  _    _  ___ 
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 * 
 *  Amazon Simple DB CSharp Library
 *  API Version: 2009-04-15
 *  Generated: Mon May 11 14:22:34 PDT 2009 
 * 
 */

using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Text;
using Attribute = Amazon.SimpleDB.Model.Attribute;

namespace Amazon.SimpleDB.Model
{
    [XmlTypeAttribute(Namespace = "http://sdb.amazonaws.com/doc/2009-04-15/")]
    [XmlRootAttribute(Namespace = "http://sdb.amazonaws.com/doc/2009-04-15/", IsNullable = false)]
    public class GetAttributesRequest
    {
    
        private String domainNameField;

        private String itemNameField;

        private List<String> attributeNameField;


        /// <summary>
        /// Gets and sets the DomainName property.
        /// </summary>
        [XmlElementAttribute(ElementName = "DomainName")]
        public String DomainName
        {
            get { return this.domainNameField ; }
            set { this.domainNameField= value; }
        }



        /// <summary>
        /// Sets the DomainName property
        /// </summary>
        /// <param name="domainName">DomainName property</param>
        /// <returns>this instance</returns>
        public GetAttributesRequest WithDomainName(String domainName)
        {
            this.domainNameField = domainName;
            return this;
        }



        /// <summary>
        /// Checks if DomainName property is set
        /// </summary>
        /// <returns>true if DomainName property is set</returns>
        public Boolean IsSetDomainName()
        {
            return  this.domainNameField != null;

        }


        /// <summary>
        /// Gets and sets the ItemName property.
        /// </summary>
        [XmlElementAttribute(ElementName = "ItemName")]
        public String ItemName
        {
            get { return this.itemNameField ; }
            set { this.itemNameField= value; }
        }



        /// <summary>
        /// Sets the ItemName property
        /// </summary>
        /// <param name="itemName">ItemName property</param>
        /// <returns>this instance</returns>
        public GetAttributesRequest WithItemName(String itemName)
        {
            this.itemNameField = itemName;
            return this;
        }



        /// <summary>
        /// Checks if ItemName property is set
        /// </summary>
        /// <returns>true if ItemName property is set</returns>
        public Boolean IsSetItemName()
        {
            return  this.itemNameField != null;

        }


        /// <summary>
        /// Gets and sets the AttributeName property.
        /// </summary>
        [XmlElementAttribute(ElementName = "AttributeName")]
        public List<String> AttributeName
        {
            get
            {
                if (this.attributeNameField == null)
                {
                    this.attributeNameField = new List<String>();
                }
                return this.attributeNameField;
            }
            set { this.attributeNameField =  value; }
        }



        /// <summary>
        /// Sets the AttributeName property
        /// </summary>
        /// <param name="list">AttributeName property</param>
        /// <returns>this instance</returns>
        public GetAttributesRequest WithAttributeName(params String[] list)
        {
            foreach (String item in list)
            {
                AttributeName.Add(item);
            }
            return this;
        }          
 


        /// <summary>
        /// Checks of AttributeName property is set
        /// </summary>
        /// <returns>true if AttributeName property is set</returns>
        public Boolean IsSetAttributeName()
        {
            return (AttributeName.Count > 0);
        }







    }

}