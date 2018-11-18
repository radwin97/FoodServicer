using FoodServicer.Data;

namespace FoodServicer.Repository
{
    public static class ContextContainer
    {
        public static FoodServicerContext Context {
            get
            {
                return new FoodServicerContext();
            }
        }
    }
}
