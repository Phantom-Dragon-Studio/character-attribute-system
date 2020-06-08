namespace PhantomDragonStudio.Environment
{
    public interface IActivatable
    {
        bool IsActive { get; set; }
        void Activate();
        void Deactivate();
    }
}
