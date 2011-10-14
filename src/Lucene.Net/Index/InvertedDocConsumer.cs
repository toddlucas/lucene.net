// -----------------------------------------------------------------------
// <copyright company="Apache" file="InvertedDocConsumer.cs">
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
    using System.Collections.Generic;

    internal abstract class InvertedDocConsumer
    {
        /// <summary>
        /// Abort (called after hitting AbortException)
        /// </summary>
        public abstract void Abort();

        /// <summary>
        /// Flush a new segment
        /// </summary>
        /// <param name="fieldsToFlush">Fields to flush</param>
        /// <param name="state">Write state</param>
        public abstract void Flush(IDictionary<FieldInfo, InvertedDocConsumerPerField> fieldsToFlush, SegmentWriteState state);

        public abstract InvertedDocConsumerPerField AddField(DocInverterPerField docInverterPerField, FieldInfo fieldInfo);

        public abstract void StartDocument();

        public abstract void FinishDocument();

        /// <summary>
        /// Attempt to free RAM, returning true if any RAM was freed
        /// </summary>
        /// <returns>Returns true if any RAM was freed, false otherwise</returns>
        public abstract bool FreeRAM();
    }
}
