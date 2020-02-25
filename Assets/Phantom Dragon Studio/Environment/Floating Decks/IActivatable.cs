namespace PhantomDragonStudio.Environment
{
    public interface IActivatable
    {
        bool IsActive { get; set; }
        void Activate(float time = -1);
        void Deactivate();
    }
}
