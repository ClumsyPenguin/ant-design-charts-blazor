using OneOf;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace AntDesign.Charts
{
    public class LiquidConfig : ILiquidViewConfig, IPlotConfig
    {
[JsonPropertyName("statistic")]
public LiquidStatisticStyle Statistic { get; set; }
[JsonPropertyName("liquidSize")]
public int? LiquidSize { get; set; }
[JsonPropertyName("min")]
public int? Min { get; set; }
[JsonPropertyName("max")]
public int? Max { get; set; }
[JsonPropertyName("value")]
public int? Value { get; set; }
[JsonPropertyName("liquidStyle")]
public object LiquidStyle { get; set; }
[JsonPropertyName("renderer")]
public string Renderer { get; set; }
[JsonPropertyName("data")]
public object Data { get; set; }
[JsonPropertyName("meta")]
public object Meta { get; set; }
[JsonPropertyName("padding")]
public string Padding { get; set; }
[JsonPropertyName("xField")]
public string XField { get; set; }
[JsonPropertyName("yField")]
public string YField { get; set; }
[JsonPropertyName("color")]
public string[] Color { get; set; }
[JsonPropertyName("xAxis")]
public Axis XAxis { get; set; }
[JsonPropertyName("yAxis")]
public Axis YAxis { get; set; }
[JsonPropertyName("label")]
public Label Label { get; set; }
[JsonPropertyName("tooltip")]
public Tooltip Tooltip { get; set; }
[JsonPropertyName("legend")]
public Legend Legend { get; set; }
[JsonPropertyName("animation")]
public object Animation { get; set; }
        [JsonIgnore]
        public OneOf<string, object> Theme { get; set; }
        [JsonPropertyName("theme")]
        public object themeMapping => Theme.Value;
[JsonPropertyName("responsiveTheme")]
public object ResponsiveTheme { get; set; }
[JsonPropertyName("interactions")]
public Interaction[] Interactions { get; set; }
[JsonPropertyName("responsive")]
public bool? Responsive { get; set; }
[JsonPropertyName("title")]
public Title Title { get; set; }
[JsonPropertyName("description")]
public Description Description { get; set; }
[JsonPropertyName("guideLine")]
public GuideLineConfig[] GuideLine { get; set; }
[JsonPropertyName("defaultState")]
public ViewConfigDefaultState DefaultState { get; set; }
[JsonPropertyName("name")]
public string Name { get; set; }
[JsonPropertyName("forceFit")]
public bool? ForceFit { get; set; }
[JsonPropertyName("width")]
public int? Width { get; set; }
[JsonPropertyName("height")]
public int? Height { get; set; }
[JsonPropertyName("pixelRatio")]
public int? PixelRatio { get; set; }
[JsonPropertyName("localRefresh")]
public bool? LocalRefresh { get; set; }
    }

    public interface ILiquidViewConfig : IViewConfig
    {
[JsonPropertyName("statistic")]
public LiquidStatisticStyle Statistic { get; set; }
[JsonPropertyName("liquidSize")]
public int? LiquidSize { get; set; }
[JsonPropertyName("min")]
public int? Min { get; set; }
[JsonPropertyName("max")]
public int? Max { get; set; }
[JsonPropertyName("value")]
public int? Value { get; set; }
[JsonPropertyName("liquidStyle")]
public object LiquidStyle { get; set; }//OneOf<LiquidStyle, ((...args: any[]) => LiquidStyle)>

    }

    public interface ILiquidStatisticStyle
    {
[JsonPropertyName("visible")]
public bool? Visible { get; set; }
[JsonPropertyName("formatter")]
public string Formatter { get; set; }//(value) => string
[JsonPropertyName("style")]
public TextStyle Style { get; set; }
[JsonPropertyName("adjustColor")]
public bool? AdjustColor { get; set; }
[JsonPropertyName("htmlContent")]
public string HtmlContent { get; set; }//(...args: any) => string

    }

    public class LiquidStatisticStyle : ILiquidStatisticStyle
    {
[JsonPropertyName("visible")]
public bool? Visible { get; set; }
[JsonPropertyName("formatter")]
public string Formatter { get; set; }
[JsonPropertyName("style")]
public TextStyle Style { get; set; }
[JsonPropertyName("adjustColor")]
public bool? AdjustColor { get; set; }
[JsonPropertyName("htmlContent")]
public string HtmlContent { get; set; }
    }

}

