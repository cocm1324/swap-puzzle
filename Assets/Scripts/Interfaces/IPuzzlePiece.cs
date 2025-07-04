namespace SwapPuzzle.Interfaces
{
    /// <summary>
    /// Represents a single piece in the puzzle grid
    /// </summary>
    public interface IPuzzlePiece
    {
        /// <summary>
        /// The original X position in the grid
        /// </summary>
        int OriginalX { get; }

        /// <summary>
        /// The original Y position in the grid
        /// </summary>
        int OriginalY { get; }

        /// <summary>
        /// Whether the piece is in its correct position
        /// </summary>
        bool IsSolved { get; }

        /// <summary>
        /// Marks the piece as solved
        /// </summary>
        void MarkAsSolved();
    }
} 