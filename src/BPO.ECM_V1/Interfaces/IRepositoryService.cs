using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BPO.ECM_V1 {
    public interface IRepositoryService : IDisposable {

        ConsumerType SupportedConsumerFarm { get; }

        IEnumerable<RepositoryServiceOperation> ServiceType { get; }

        void Create();

        void Update();

        void Read();

        void Delete();

    }

    public enum RepositoryServiceOperation {
        Create,
        Read,
        Update,
        Delete,
        Search,
        All
    }
}
