

namespace BLL.DTO
{
    public class PollResultDTO
    {
        /// <summary>
        /// Unique id of result
        /// </summary>
        public int PollResultId { get; set; }

        /// <summary>
        /// Name of participant
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Unique email
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// True if participant is married
        /// </summary>
        public bool IsMarried { get; set; }

        /// <summary>
        /// Year of birth
        /// </summary>
        public int BornIn { get; set; }
    }
}
