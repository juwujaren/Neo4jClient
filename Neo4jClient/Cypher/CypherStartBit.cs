using System.Collections.Generic;

namespace Neo4jClient.Cypher
{
    internal class CypherStartBit
    {
        readonly string identifier;
        readonly string lookupType;
        readonly IEnumerable<int> lookupIds;

        public CypherStartBit(string identifier, string lookupType, IEnumerable<int> lookupIds)
        {
            this.identifier = identifier;
            this.lookupType = lookupType;
            this.lookupIds = lookupIds;
        }

        public string Identifier
        {
            get { return identifier; }
        }

        public string LookupType
        {
            get { return lookupType; }
        }

        public IEnumerable<int> LookupIds
        {
            get { return lookupIds; }
        }
    }
}