using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Linq;
using System.Web;

namespace azure_lucene_indexer
{
    /// <summary>
    /// An Entry in teh Lucene Index
    /// </summary>
    
    [DataContract]
    public class IndexPutAction : IndexAction
    {

        [DataMember(Name = "Entry")]
        public IndexEntry Entry { get; set; }

    }

}