using BookService.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Collections;

namespace BookService
{
    [ServiceContract]
    public interface IBookService
    {
        [OperationContract]
        [WebInvoke(
            Method = "GET",
            UriTemplate = "/getBook/{title}",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle =WebMessageBodyStyle.Bare
            )
        ]
        Book getBook(String title);

        [OperationContract]
        [WebInvoke(
            Method = "POST",
            UriTemplate = "/addBook",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle =WebMessageBodyStyle.Bare
            )
        ]
        void addBook(Book newBook);

        [OperationContract]
        [WebInvoke(
            Method = "GET",
            UriTemplate = "/getBooks",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle =WebMessageBodyStyle.Bare
            )
        ]
        Book[] getBooks();  

        [OperationContract]
        [WebInvoke(
            Method = "DELETE",
            UriTemplate = "/deleteBook/{title}",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle =WebMessageBodyStyle.Bare
            )
        ]
        void deleteBook(String title);

        [OperationContract]
        [WebInvoke(
            Method = "PUT",
            UriTemplate = "/updateBook/{title}",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle =WebMessageBodyStyle.Bare
            )
        ]
        void updateBook(String title, Book updatedBook);
    }
}
