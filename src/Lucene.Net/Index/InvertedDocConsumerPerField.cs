// -----------------------------------------------------------------------
// <copyright company="Apache" file="InvertedDocConsumerPerField.cs">
//
//      Licensed to the Apache Software Foundation (ASF) under one or more
//      contributor license agreements.  See the NOTICE file distributed with
//      this work for additional information regarding copyright ownership.
//      The ASF licenses this file to You under the Apache License, Version 2.0
//      (the "License"); you may not use this file except in compliance with
//      the License.  You may obtain a copy of the License at
// 
//      http://www.apache.org/licenses/LICENSE-2.0
// 
//      Unless required by applicable law or agreed to in writing, software
//      distributed under the License is distributed on an "AS IS" BASIS,
//      WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//      See the License for the specific language governing permissions and
//      limitations under the License.
//
// </copyright>
// -----------------------------------------------------------------------

namespace Lucene.Net.Index
{
    using Lucene.Net.Document;

    internal abstract class InvertedDocConsumerPerField
    {
        /// <summary>
        /// Called once per field, and is given all <c>IFieldable</c>
        /// occurrences for this field in the document.  Return
        /// true if you wish to see inverted tokens for these
        /// fields.
        /// </summary>
        /// <param name="fields">An array of <c>IFieldable</c> occurances for this field</param>
        /// <param name="count">A count</param>
        /// <returns>Return true to see inverted tokens for these fields</returns>
        public abstract bool Start(IFieldable[] fields, int count);

        /// <summary>
        /// Called before a field instance is being processed
        /// </summary>
        /// <param name="field">The <c>IFieldable</c> of the field instance being processed</param>
        public abstract void Start(IFieldable field);

        /// <summary>
        /// Called once per inverted token
        /// </summary>
        public abstract void Add();

        /// <summary>
        /// Called once per field per document, after all Fieldable
        /// occurrences are inverted
        /// </summary>
        public abstract void Finish();

        /// <summary>
        /// Called on hitting an aborting exception
        /// </summary>
        public abstract void Abort();
    }
}
