using Xamarin.Forms;

namespace TaskSave
{
    internal class MyListPageDetail : Page
    {
        private object name;
        private object ingredients;
        private object image;

        public MyListPageDetail(object name, object ingredients, object image)
        {
            this.name = name;
            this.ingredients = ingredients;
            this.image = image;
        }
    }
}