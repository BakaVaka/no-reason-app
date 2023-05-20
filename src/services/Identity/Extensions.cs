namespace Identity;

public interface ICore { }

public interface IHandler {
    public void Activate(ICore core);
    public void Deactivate(ICore core);
    public void Destroy();
}

public record DriverDescriptor(Type DriverSelfType, Type HanlderType, Type HandlerDescriptor);
public abstract class Driver {
    public abstract DriverDescriptor DriverDescriptor { get;  }
}

public abstract class Driver<TSelf, TDecriptor, THandler>
    : Driver
    where TSelf : Driver<TSelf, TDecriptor, THandler>
    where THandler : class {
    public abstract string Name { get; }
    public abstract Version Version { get; }
    public abstract THandler CreateHandler(TDecriptor decriptor);
}



public static class Extensions { }
