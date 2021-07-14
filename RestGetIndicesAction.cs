public class RestGetIndicesAction : BaseRestHandler {
    
    private readonly IndexScopedSettings indexScopedSettings;
    
    [Inject()]
    public RestGetIndicesAction(Settings settings, RestController controller, Client client) 
            : base(settings, controller, client) {
        controller.registerHandler(GET, "/{index}", this);
        controller.registerHandler(GET, "/{index}/{type}", this);
    }
}