using DependenyInjectionScopes.Service.Interface;

namespace DependenyInjectionScopes.Service; 
public class SingletonService : IOperationService {
    public Guid OperationId { get; private set; }
    public SingletonService() {
        OperationId = Guid.NewGuid();
    }
}
