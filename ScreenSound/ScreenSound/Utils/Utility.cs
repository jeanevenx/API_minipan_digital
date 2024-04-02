
namespace ScreenSound.Utils;

public class Utility
{

    public static Object GetObjectProprietyValue(object obj, string name)
    {


        return obj.GetType().GetProperty(name)?.GetValue(obj)!;
    }
}
