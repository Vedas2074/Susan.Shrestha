namespace AccessModifierAndMethods
{
class AccessModifier // default accessmodifier of class is internal
{
   internal void DoSomething() //accessable inside a project, function default accessmodifier is private
    {

    }

   public int CalculateAverage(int[] numbers) //accesable to all project
    {
        return 0;
    }
}
}