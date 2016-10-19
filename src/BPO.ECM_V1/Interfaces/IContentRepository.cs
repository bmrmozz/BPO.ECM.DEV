using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BPO.ECM_V1 {

    public interface IContentRepository : IDisposable {

        bool IsConfigured { get; set; }

        bool CanSearch { get; set; }

        RepositoryType RepositoryType { get; set; }

        ConsumerType ConsumerType { get; set; }

        ServiceType ServiceType { get; set; }

        IEnumerable<IRepositoryService> RepositoryServices { get; }

        IRepositoryService Get(ConsumerType consumerType, RepositoryServiceOperation requiredOperation);

        bool Validate();

        bool IsAlive();

        void Create();

        void Read();

        void Update();

        void Delete();

        void Search();
    }

    public enum RepositoryType {
        Default,
        Caching,
        Replicating,
        FixedSize,
        Watch
    }

    public enum ConsumerType {
        Database,
        Service,
        FileSystem
    }

    public enum ServiceType {
        DataAPIService,
        ObjectAPIService
    }
}
