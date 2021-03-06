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


namespace Amazon.SimpleDB.Model
{
    [XmlTypeAttribute(Namespace = "http://sdb.amazonaws.com/doc/2009-04-15/")]
    [XmlRootAttribute(Namespace = "http://sdb.amazonaws.com/doc/2009-04-15/", IsNullable = false)]
    public class DeleteDomainRequest
    {
    
        private String domainNameField;


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
        public DeleteDomainRequest WithDomainName(String domainName)
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





    }

}