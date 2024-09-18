using DependenyInjectionScopes.Service.Interface;

namespace DependenyInjectionScopes.Service;
public class ScopedService : IOperationService {
    public Guid OperationId { get; private set; }
    public ScopedService() {
        OperationId = Guid.NewGuid();
    }
}
