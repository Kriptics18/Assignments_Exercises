using Assignment4.CodingQ3.Entities;
using Assignment4.CodingQ3.Interfaces;
using Assignment4.CodingQ3.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4.CodingQ3 {
    internal class TestRun {

        static void Main() {
            IRepository<Entity> repository = new GenericRepository<Entity>();

            // Add some entities
            repository.Add(new Entity { Name = "Entity 1" });
            repository.Add(new Entity { Name = "Entity 2" });

            // Save changes (in this case, it will just maintain the in-memory list)
            repository.Save();

            // Get all entities and print them
            IEnumerable<Entity> allEntities = repository.GetAll();
            foreach (var entity in allEntities) {
                Console.WriteLine($"Id: {entity.Id}, Name: {entity.Name}");
            }

            // Get an entity by ID
            Entity entityById = repository.GetById(1)!;
            Console.WriteLine($"Entity with ID 1: Name = {entityById.Name}");

            // Remove an entity
            repository.Remove(entityById);

            // Get all entities after removal
            allEntities = repository.GetAll();
            foreach (var entity in allEntities) {
                Console.WriteLine($"Id: {entity.Id}, Name: {entity.Name}");
            }
        }

    }
}
