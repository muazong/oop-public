interface IBook {
  /// <summary>
  /// @Description: The index represents the book's chapter.
  /// </summary>
  string this[int index] {
    get;
    set;
  }

  /// <summary>
  /// @Description: Book's title.
  /// </summary>
  string Title { get; set; }

  /// <summary>
  /// @Description: Author of the book.
  /// </summary>
  string Author { get; set; }

  /// <summary>
  /// @Description: Publisher of the book.
  /// </summary>
  string Publisher { get; set; }

  /// <summary>
  /// @Description: The International Standard Book Number.
  /// </summary>
  string ISBN { get; set; }

  /// <summary>
  /// @Description: Year of publication.
  /// </summary>
  int Year { get; set; }

  /// <summary>
  /// @Description: Show the book's information.
  /// </summary>
  void Show();
}
