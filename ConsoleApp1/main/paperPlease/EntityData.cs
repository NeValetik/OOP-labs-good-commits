﻿using System;

namespace PaperPlease
{
    public class EntityData
    {
        private List<Entity>? Data { get; set; }

        public void AddEntity(Entity entity)
        {
            if (Data == null)
            {
                Data = new List<Entity>();
            }
            Data.Add(entity);
        }

        public List<Entity>? GetData() { return Data; }
    }
}
