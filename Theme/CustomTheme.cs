using MudBlazor;

namespace MudblazorThemeIssue.Theme;

public class CustomTheme : MudTheme
{
    public CustomTheme()
    {
        PaletteDark = new PaletteDark
        {
            Black = "rgba(39,39,47,1)",
            Primary = "#39b54aff",
            Info = "rgba(50,153,255,1)",
            Success = "rgba(11,186,131,1)",
            Warning = "rgba(255,168,0,1)",
            Error = "rgba(246,78,98,1)",
            Dark = "rgba(39,39,47,1)",
            TextPrimary = "rgba(255,255,255,0.6980392156862745)",
            TextSecondary = "rgba(255,255,255,0.4980392156862745)",
            TextDisabled = "rgba(255,255,255,0.2)",
            ActionDefault = "rgba(173,173,177,1)",
            ActionDisabled = "rgba(255,255,255,0.25882352941176473)",
            ActionDisabledBackground = "rgba(255,255,255,0.11764705882352941)",
            Background = "#31333C",
            BackgroundGray = "#31333C",
            Surface = "#373740",
            DrawerBackground = "#27272E",
            DrawerText = "rgba(255,255,255,0.4980392156862745)",
            DrawerIcon = "rgba(255,255,255,0.4980392156862745)",
            AppbarBackground = "#27272E",
            AppbarText = "rgba(255,255,255,0.6980392156862745)",
            LinesDefault = "rgba(255,255,255,0.11764705882352941)",
            LinesInputs = "rgba(255,255,255,0.2980392156862745)",
            TableLines = "rgba(255,255,255,0.11764705882352941)",
            TableStriped = "rgba(255,255,255,0.2)",
            Divider = "rgba(255,255,255,0.11764705882352941)",
            DividerLight = "rgba(255,255,255,0.058823529411764705)",
            PrimaryDarken = "#2d8f3aff",
            PrimaryLighten = "#5fc96fff",
            InfoDarken = "rgb(10,133,255)",
            InfoLighten = "rgb(92,173,255)",
            SuccessDarken = "rgb(9,154,108)",
            SuccessLighten = "rgb(13,222,156)",
            WarningDarken = "rgb(214,143,0)",
            WarningLighten = "rgb(255,182,36)",
            ErrorDarken = "rgb(244,47,70)",
            ErrorLighten = "rgb(248,119,134)",
            DarkDarken = "rgb(23,23,28)",
            DarkLighten = "rgb(56,56,67)"
        };

        Typography = CustomTypography.FSHTypography;
        LayoutProperties = new LayoutProperties
        {
            DrawerWidthLeft = "260px",
            DrawerWidthRight = "300px"
        };
    }
}
