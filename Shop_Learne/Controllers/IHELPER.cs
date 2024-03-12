namespace Shop_Learne.Controllers
{
    public interface IHELPER<T>
    {
        public IQueryable<T> Query();
    }
}
