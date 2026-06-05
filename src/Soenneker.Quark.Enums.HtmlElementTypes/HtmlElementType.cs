using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// The html element types in enum form.
/// </summary>
[EnumValue<string>]
public sealed partial class HtmlElementType
{
    // Document metadata
    /// <summary>
    /// The html.
    /// </summary>
    public static readonly HtmlElementType Html = new("html");
    /// <summary>
    /// The head.
    /// </summary>
    public static readonly HtmlElementType Head = new("head");
    /// <summary>
    /// The title.
    /// </summary>
    public static readonly HtmlElementType Title = new("title");
    /// <summary>
    /// The base.
    /// </summary>
    public static readonly HtmlElementType Base = new("base");
    /// <summary>
    /// The link.
    /// </summary>
    public static readonly HtmlElementType Link = new("link");
    /// <summary>
    /// The meta.
    /// </summary>
    public static readonly HtmlElementType Meta = new("meta");
    /// <summary>
    /// The style.
    /// </summary>
    public static readonly HtmlElementType Style = new("style");

    // Sectioning root
    /// <summary>
    /// The body.
    /// </summary>
    public static readonly HtmlElementType Body = new("body");

    // Content sectioning
    /// <summary>
    /// The header.
    /// </summary>
    public static readonly HtmlElementType Header = new("header");
    /// <summary>
    /// The footer.
    /// </summary>
    public static readonly HtmlElementType Footer = new("footer");
    /// <summary>
    /// The main.
    /// </summary>
    public static readonly HtmlElementType Main = new("main");
    /// <summary>
    /// The section.
    /// </summary>
    public static readonly HtmlElementType Section = new("section");
    /// <summary>
    /// The nav.
    /// </summary>
    public static readonly HtmlElementType Nav = new("nav");
    /// <summary>
    /// The article.
    /// </summary>
    public static readonly HtmlElementType Article = new("article");
    /// <summary>
    /// The aside.
    /// </summary>
    public static readonly HtmlElementType Aside = new("aside");
    /// <summary>
    /// The address.
    /// </summary>
    public static readonly HtmlElementType Address = new("address");
    /// <summary>
    /// The h1.
    /// </summary>
    public static readonly HtmlElementType H1 = new("h1");
    /// <summary>
    /// The h2.
    /// </summary>
    public static readonly HtmlElementType H2 = new("h2");
    /// <summary>
    /// The h3.
    /// </summary>
    public static readonly HtmlElementType H3 = new("h3");
    /// <summary>
    /// The h4.
    /// </summary>
    public static readonly HtmlElementType H4 = new("h4");
    /// <summary>
    /// The h5.
    /// </summary>
    public static readonly HtmlElementType H5 = new("h5");
    /// <summary>
    /// The h6.
    /// </summary>
    public static readonly HtmlElementType H6 = new("h6");

    // Text content
    /// <summary>
    /// The p.
    /// </summary>
    public static readonly HtmlElementType P = new("p");
    /// <summary>
    /// The hr.
    /// </summary>
    public static readonly HtmlElementType Hr = new("hr");
    /// <summary>
    /// The pre.
    /// </summary>
    public static readonly HtmlElementType Pre = new("pre");
    /// <summary>
    /// The blockquote.
    /// </summary>
    public static readonly HtmlElementType Blockquote = new("blockquote");
    /// <summary>
    /// The ol.
    /// </summary>
    public static readonly HtmlElementType Ol = new("ol");
    /// <summary>
    /// The ul.
    /// </summary>
    public static readonly HtmlElementType Ul = new("ul");
    /// <summary>
    /// The li.
    /// </summary>
    public static readonly HtmlElementType Li = new("li");
    /// <summary>
    /// The dl.
    /// </summary>
    public static readonly HtmlElementType Dl = new("dl");
    /// <summary>
    /// The dt.
    /// </summary>
    public static readonly HtmlElementType Dt = new("dt");
    /// <summary>
    /// The dd.
    /// </summary>
    public static readonly HtmlElementType Dd = new("dd");
    /// <summary>
    /// The figure.
    /// </summary>
    public static readonly HtmlElementType Figure = new("figure");
    /// <summary>
    /// The figcaption.
    /// </summary>
    public static readonly HtmlElementType Figcaption = new("figcaption");
    /// <summary>
    /// The div.
    /// </summary>
    public static readonly HtmlElementType Div = new("div");

    // Inline text semantics
    /// <summary>
    /// The a.
    /// </summary>
    public static readonly HtmlElementType A = new("a");
    /// <summary>
    /// The em.
    /// </summary>
    public static readonly HtmlElementType Em = new("em");
    /// <summary>
    /// The strong.
    /// </summary>
    public static readonly HtmlElementType Strong = new("strong");
    /// <summary>
    /// The small.
    /// </summary>
    public static readonly HtmlElementType Small = new("small");
    /// <summary>
    /// The s.
    /// </summary>
    public static readonly HtmlElementType S = new("s");
    /// <summary>
    /// The cite.
    /// </summary>
    public static readonly HtmlElementType Cite = new("cite");
    /// <summary>
    /// The q.
    /// </summary>
    public static readonly HtmlElementType Q = new("q");
    /// <summary>
    /// The dfn.
    /// </summary>
    public static readonly HtmlElementType Dfn = new("dfn");
    /// <summary>
    /// The abbr.
    /// </summary>
    public static readonly HtmlElementType Abbr = new("abbr");
    /// <summary>
    /// The ruby.
    /// </summary>
    public static readonly HtmlElementType Ruby = new("ruby");
    /// <summary>
    /// The rt.
    /// </summary>
    public static readonly HtmlElementType Rt = new("rt");
    /// <summary>
    /// The rp.
    /// </summary>
    public static readonly HtmlElementType Rp = new("rp");
    /// <summary>
    /// The data.
    /// </summary>
    public static readonly HtmlElementType Data = new("data");
    /// <summary>
    /// The time.
    /// </summary>
    public static readonly HtmlElementType Time = new("time");
    /// <summary>
    /// The code.
    /// </summary>
    public static readonly HtmlElementType Code = new("code");
    /// <summary>
    /// The var.
    /// </summary>
    public static readonly HtmlElementType Var = new("var");
    /// <summary>
    /// The samp.
    /// </summary>
    public static readonly HtmlElementType Samp = new("samp");
    /// <summary>
    /// The kbd.
    /// </summary>
    public static readonly HtmlElementType Kbd = new("kbd");
    /// <summary>
    /// The sub.
    /// </summary>
    public static readonly HtmlElementType Sub = new("sub");
    /// <summary>
    /// The sup.
    /// </summary>
    public static readonly HtmlElementType Sup = new("sup");
    /// <summary>
    /// The i.
    /// </summary>
    public static readonly HtmlElementType I = new("i");
    /// <summary>
    /// The b.
    /// </summary>
    public static readonly HtmlElementType B = new("b");
    /// <summary>
    /// The u.
    /// </summary>
    public static readonly HtmlElementType U = new("u");
    /// <summary>
    /// The mark.
    /// </summary>
    public static readonly HtmlElementType Mark = new("mark");
    /// <summary>
    /// The bdi.
    /// </summary>
    public static readonly HtmlElementType Bdi = new("bdi");
    /// <summary>
    /// The bdo.
    /// </summary>
    public static readonly HtmlElementType Bdo = new("bdo");
    /// <summary>
    /// The span.
    /// </summary>
    public static readonly HtmlElementType Span = new("span");
    /// <summary>
    /// The br.
    /// </summary>
    public static readonly HtmlElementType Br = new("br");
    /// <summary>
    /// The wbr.
    /// </summary>
    public static readonly HtmlElementType Wbr = new("wbr");

    // Edits
    /// <summary>
    /// The ins.
    /// </summary>
    public static readonly HtmlElementType Ins = new("ins");
    /// <summary>
    /// The del.
    /// </summary>
    public static readonly HtmlElementType Del = new("del");

    // Embedded content
    /// <summary>
    /// The picture.
    /// </summary>
    public static readonly HtmlElementType Picture = new("picture");
    /// <summary>
    /// The source.
    /// </summary>
    public static readonly HtmlElementType Source = new("source");
    /// <summary>
    /// The img.
    /// </summary>
    public static readonly HtmlElementType Img = new("img");
    /// <summary>
    /// The iframe.
    /// </summary>
    public static readonly HtmlElementType Iframe = new("iframe");
    /// <summary>
    /// The embed.
    /// </summary>
    public static readonly HtmlElementType Embed = new("embed");
    /// <summary>
    /// The object.
    /// </summary>
    public static readonly HtmlElementType Object = new("object");
    /// <summary>
    /// The param.
    /// </summary>
    public static readonly HtmlElementType Param = new("param");
    /// <summary>
    /// The video.
    /// </summary>
    public static readonly HtmlElementType Video = new("video");
    /// <summary>
    /// The audio.
    /// </summary>
    public static readonly HtmlElementType Audio = new("audio");
    /// <summary>
    /// The track.
    /// </summary>
    public static readonly HtmlElementType Track = new("track");
    /// <summary>
    /// The map.
    /// </summary>
    public static readonly HtmlElementType Map = new("map");
    /// <summary>
    /// The area.
    /// </summary>
    public static readonly HtmlElementType Area = new("area");
    /// <summary>
    /// The canvas.
    /// </summary>
    public static readonly HtmlElementType Canvas = new("canvas");
    /// <summary>
    /// The svg.
    /// </summary>
    public static readonly HtmlElementType Svg = new("svg");
    /// <summary>
    /// The math.
    /// </summary>
    public static readonly HtmlElementType Math = new("math");

    // Tabular data
    /// <summary>
    /// The table.
    /// </summary>
    public static readonly HtmlElementType Table = new("table");
    /// <summary>
    /// The caption.
    /// </summary>
    public static readonly HtmlElementType Caption = new("caption");
    /// <summary>
    /// The colgroup.
    /// </summary>
    public static readonly HtmlElementType Colgroup = new("colgroup");
    /// <summary>
    /// The col.
    /// </summary>
    public static readonly HtmlElementType Col = new("col");
    /// <summary>
    /// The tbody.
    /// </summary>
    public static readonly HtmlElementType Tbody = new("tbody");
    /// <summary>
    /// The thead.
    /// </summary>
    public static readonly HtmlElementType Thead = new("thead");
    /// <summary>
    /// The tfoot.
    /// </summary>
    public static readonly HtmlElementType Tfoot = new("tfoot");
    /// <summary>
    /// The tr.
    /// </summary>
    public static readonly HtmlElementType Tr = new("tr");
    /// <summary>
    /// The td.
    /// </summary>
    public static readonly HtmlElementType Td = new("td");
    /// <summary>
    /// The th.
    /// </summary>
    public static readonly HtmlElementType Th = new("th");

    // Forms
    /// <summary>
    /// The form.
    /// </summary>
    public static readonly HtmlElementType Form = new("form");
    /// <summary>
    /// The label.
    /// </summary>
    public static readonly HtmlElementType Label = new("label");
    /// <summary>
    /// The input.
    /// </summary>
    public static readonly HtmlElementType Input = new("input");
    /// <summary>
    /// The button.
    /// </summary>
    public static readonly HtmlElementType Button = new("button");
    /// <summary>
    /// The select.
    /// </summary>
    public static readonly HtmlElementType Select = new("select");
    /// <summary>
    /// The datalist.
    /// </summary>
    public static readonly HtmlElementType Datalist = new("datalist");
    /// <summary>
    /// The optgroup.
    /// </summary>
    public static readonly HtmlElementType Optgroup = new("optgroup");
    /// <summary>
    /// The option.
    /// </summary>
    public static readonly HtmlElementType Option = new("option");
    /// <summary>
    /// The textarea.
    /// </summary>
    public static readonly HtmlElementType Textarea = new("textarea");
    /// <summary>
    /// The output.
    /// </summary>
    public static readonly HtmlElementType Output = new("output");
    /// <summary>
    /// The progress.
    /// </summary>
    public static readonly HtmlElementType Progress = new("progress");
    /// <summary>
    /// The meter.
    /// </summary>
    public static readonly HtmlElementType Meter = new("meter");
    /// <summary>
    /// The fieldset.
    /// </summary>
    public static readonly HtmlElementType Fieldset = new("fieldset");
    /// <summary>
    /// The legend.
    /// </summary>
    public static readonly HtmlElementType Legend = new("legend");

    // Interactive elements
    /// <summary>
    /// The details.
    /// </summary>
    public static readonly HtmlElementType Details = new("details");
    /// <summary>
    /// The summary.
    /// </summary>
    public static readonly HtmlElementType Summary = new("summary");
    /// <summary>
    /// The dialog.
    /// </summary>
    public static readonly HtmlElementType Dialog = new("dialog");
    /// <summary>
    /// The menu.
    /// </summary>
    public static readonly HtmlElementType Menu = new("menu");
    /// <summary>
    /// The slot.
    /// </summary>
    public static readonly HtmlElementType Slot = new("slot");
    /// <summary>
    /// The template.
    /// </summary>
    public static readonly HtmlElementType Template = new("template");
}
