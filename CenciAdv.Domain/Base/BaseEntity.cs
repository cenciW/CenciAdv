
namespace CenciAdv.Domain.Base
{
    public abstract class BaseEntity<IId> : IBaseEntity
    {

        protected BaseEntity() { }
        public BaseEntity(IId id)
        {
            Id = id;
        }
        public IId? Id { get; set; }
    }
}
