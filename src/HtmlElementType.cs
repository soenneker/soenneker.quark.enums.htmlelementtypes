using Intellenum;

namespace Soenneker.Quark.Enums.HtmlElementTypes;

/// <summary>
/// The html element types in enum form.
/// </summary>
[Intellenum<string>]
public sealed partial class HtmlElementType
{
    // Document metadata
    public static readonly HtmlElementType Html = new("html");
    public static readonly HtmlElementType Head = new("head");
    public static readonly HtmlElementType Title = new("title");
    public static readonly HtmlElementType Base = new("base");
    public static readonly HtmlElementType Link = new("link");
    public static readonly HtmlElementType Meta = new("meta");
    public static readonly HtmlElementType Style = new("style");

    // Sectioning root
    public static readonly HtmlElementType Body = new("body");

    // Content sectioning
    public static readonly HtmlElementType Header = new("header");
    public static readonly HtmlElementType Footer = new("footer");
    public static readonly HtmlElementType Main = new("main");
    public static readonly HtmlElementType Section = new("section");
    public static readonly HtmlElementType Nav = new("nav");
    public static readonly HtmlElementType Article = new("article");
    public static readonly HtmlElementType Aside = new("aside");
    public static readonly HtmlElementType Address = new("address");
    public static readonly HtmlElementType H1 = new("h1");
    public static readonly HtmlElementType H2 = new("h2");
    public static readonly HtmlElementType H3 = new("h3");
    public static readonly HtmlElementType H4 = new("h4");
    public static readonly HtmlElementType H5 = new("h5");
    public static readonly HtmlElementType H6 = new("h6");

    // Text content
    public static readonly HtmlElementType P = new("p");
    public static readonly HtmlElementType Hr = new("hr");
    public static readonly HtmlElementType Pre = new("pre");
    public static readonly HtmlElementType Blockquote = new("blockquote");
    public static readonly HtmlElementType Ol = new("ol");
    public static readonly HtmlElementType Ul = new("ul");
    public static readonly HtmlElementType Li = new("li");
    public static readonly HtmlElementType Dl = new("dl");
    public static readonly HtmlElementType Dt = new("dt");
    public static readonly HtmlElementType Dd = new("dd");
    public static readonly HtmlElementType Figure = new("figure");
    public static readonly HtmlElementType Figcaption = new("figcaption");
    public static readonly HtmlElementType Div = new("div");

    // Inline text semantics
    public static readonly HtmlElementType A = new("a");
    public static readonly HtmlElementType Em = new("em");
    public static readonly HtmlElementType Strong = new("strong");
    public static readonly HtmlElementType Small = new("small");
    public static readonly HtmlElementType S = new("s");
    public static readonly HtmlElementType Cite = new("cite");
    public static readonly HtmlElementType Q = new("q");
    public static readonly HtmlElementType Dfn = new("dfn");
    public static readonly HtmlElementType Abbr = new("abbr");
    public static readonly HtmlElementType Ruby = new("ruby");
    public static readonly HtmlElementType Rt = new("rt");
    public static readonly HtmlElementType Rp = new("rp");
    public static readonly HtmlElementType Data = new("data");
    public static readonly HtmlElementType Time = new("time");
    public static readonly HtmlElementType Code = new("code");
    public static readonly HtmlElementType Var = new("var");
    public static readonly HtmlElementType Samp = new("samp");
    public static readonly HtmlElementType Kbd = new("kbd");
    public static readonly HtmlElementType Sub = new("sub");
    public static readonly HtmlElementType Sup = new("sup");
    public static readonly HtmlElementType I = new("i");
    public static readonly HtmlElementType B = new("b");
    public static readonly HtmlElementType U = new("u");
    public static readonly HtmlElementType Mark = new("mark");
    public static readonly HtmlElementType Bdi = new("bdi");
    public static readonly HtmlElementType Bdo = new("bdo");
    public static readonly HtmlElementType Span = new("span");
    public static readonly HtmlElementType Br = new("br");
    public static readonly HtmlElementType Wbr = new("wbr");

    // Edits
    public static readonly HtmlElementType Ins = new("ins");
    public static readonly HtmlElementType Del = new("del");

    // Embedded content
    public static readonly HtmlElementType Picture = new("picture");
    public static readonly HtmlElementType Source = new("source");
    public static readonly HtmlElementType Img = new("img");
    public static readonly HtmlElementType Iframe = new("iframe");
    public static readonly HtmlElementType Embed = new("embed");
    public static readonly HtmlElementType Object = new("object");
    public static readonly HtmlElementType Param = new("param");
    public static readonly HtmlElementType Video = new("video");
    public static readonly HtmlElementType Audio = new("audio");
    public static readonly HtmlElementType Track = new("track");
    public static readonly HtmlElementType Map = new("map");
    public static readonly HtmlElementType Area = new("area");
    public static readonly HtmlElementType Canvas = new("canvas");
    public static readonly HtmlElementType Svg = new("svg");
    public static readonly HtmlElementType Math = new("math");

    // Tabular data
    public static readonly HtmlElementType Table = new("table");
    public static readonly HtmlElementType Caption = new("caption");
    public static readonly HtmlElementType Colgroup = new("colgroup");
    public static readonly HtmlElementType Col = new("col");
    public static readonly HtmlElementType Tbody = new("tbody");
    public static readonly HtmlElementType Thead = new("thead");
    public static readonly HtmlElementType Tfoot = new("tfoot");
    public static readonly HtmlElementType Tr = new("tr");
    public static readonly HtmlElementType Td = new("td");
    public static readonly HtmlElementType Th = new("th");

    // Forms
    public static readonly HtmlElementType Form = new("form");
    public static readonly HtmlElementType Label = new("label");
    public static readonly HtmlElementType Input = new("input");
    public static readonly HtmlElementType Button = new("button");
    public static readonly HtmlElementType Select = new("select");
    public static readonly HtmlElementType Datalist = new("datalist");
    public static readonly HtmlElementType Optgroup = new("optgroup");
    public static readonly HtmlElementType Option = new("option");
    public static readonly HtmlElementType Textarea = new("textarea");
    public static readonly HtmlElementType Output = new("output");
    public static readonly HtmlElementType Progress = new("progress");
    public static readonly HtmlElementType Meter = new("meter");
    public static readonly HtmlElementType Fieldset = new("fieldset");
    public static readonly HtmlElementType Legend = new("legend");

    // Interactive elements
    public static readonly HtmlElementType Details = new("details");
    public static readonly HtmlElementType Summary = new("summary");
    public static readonly HtmlElementType Dialog = new("dialog");
    public static readonly HtmlElementType Menu = new("menu");
    public static readonly HtmlElementType Slot = new("slot");
    public static readonly HtmlElementType Template = new("template");
}