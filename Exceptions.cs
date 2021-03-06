﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AdeSAAS.DataService.Tracking
{
    public class PropertyVersionTypeMisMatchException : Exception
    {
        public PropertyVersionTypeMisMatchException()
            : base("Inserted version type does not match declared version type of the property")
        {
        }
    }

    public class EntityVersionTypeMisMatchException : Exception
    {
        public EntityVersionTypeMisMatchException()
            : base("Inserted version type does not match declared version type of the entity")
        {
        }
    }

    public class OldVersionInsertionException : Exception
    {
        public OldVersionInsertionException()
            : base("Cannot add a version older than or equal to the current latest.")
        {
        }
    }
}
