namespace Marvin.AbstractionLayer.Drivers.Marking
{
    /// <summary>
    /// Response of the marking file setup
    /// </summary>
    public class MarkingFileResponse : TransmissionResult
    {
        /// <summary>
        /// Successfull marking file setup
        /// </summary>
        public MarkingFileResponse() : base()
        {
            
        }

        /// <summary>
        /// Faulty marking file setup
        /// </summary>
        /// <param name="errorMessage">Occured error</param>
        public MarkingFileResponse(string errorMessage) : base(new TransmissionError(errorMessage))
        {
            
        }
    }
}