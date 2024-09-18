namespace DependenyInjectionScopes.Service; 
public class TransientService {
    public Guid OperationId { get; private set; }
    public TransientService() {
        OperationId = Guid.NewGuid();
    }
}
