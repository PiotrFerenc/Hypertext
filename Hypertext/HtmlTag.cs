using System.ComponentModel.DataAnnotations;
using NetEscapades.EnumGenerators;

namespace Hypertext;

[EnumExtensions]
public enum HtmlTag
{
    [Display(Name = "div")] Div,
    [Display(Name = "span")] Span,
    [Display(Name = "p")] P,
    [Display(Name = "a")] A,
    [Display(Name = "ul")] Ul,
    [Display(Name = "li")] Li,
    [Display(Name = "h1")] H1,
    [Display(Name = "h2")] H2,
    [Display(Name = "h3")] H3,
    [Display(Name = "h4")] H4,
    [Display(Name = "h5")] H5,
    [Display(Name = "h6")] H6,
    [Display(Name = "img")] Img,
    [Display(Name = "input")] Input,
    [Display(Name = "button")] Button,
    [Display(Name = "mark")] Mark,
    [Display(Name = "del")] Del,
    [Display(Name = "s")] S,
    [Display(Name = "ins")] Ins,
    [Display(Name = "u")] U,
    [Display(Name = "small")] Small,
    [Display(Name = "strong")] Strong,
    [Display(Name = "em")] Em,
    [Display(Name = "table")] Table,
    [Display(Name = "tr")] Tr,
    [Display(Name = "thead")] Thead,
    [Display(Name = "tbody")] Tbody,
    [Display(Name = "tfoot")] Tfoot,
    [Display(Name = "th")] Th,
    [Display(Name = "td")] Td,
    [Display(Name = "select")] Select,
    [Display(Name = "textarea")] TextArea,
    [Display(Name = "nav")] Nav,
    [Display(Name = "ol")] Ol
}