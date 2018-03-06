namespace CourseScheduler.AutoMapper.Factories
{
    public class AutoMapperFactory
    {
        /// <summary>
        /// This factory will Map an object to another object without having 
        /// the reference to AutoMapper in your code.
        /// </summary>
        /// <typeparam name="T">The <see cref="T"/> you want to get after Mapping.</typeparam>
        /// <param name="objectToMap">The object you want to Map.</param>
        /// <returns>The Mapped object.</returns>
        public static T Map<T>(object objectToMap)
            where T : class
        {
            return global::AutoMapper.Mapper.Map<T>(objectToMap);
        }
    }
}