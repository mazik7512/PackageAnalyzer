using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BaseModule;
using System.Windows.Forms;
using System.Drawing;
using BinaryStructureModuleGraph;

public class BinaryStructureModuleGraphic : IModule
{

    private BinaryStructureModuleGraph.MainForm mainForm = new BinaryStructureModuleGraph.MainForm();

    public string moduleName
    {
        get { return "Бинарная структура"; }
    }

    public string moduleVersion
    {
        get { return "Версия 2.0"; }
    }

    public string moduleDesc
    {
        get { return "Модуль, позволяющий просмотреть бинарную структуру в графическом и текстовом видах"; }
    }

    public Bitmap icon
    {
        get { return BinaryStructureModuleGraph.Resource.GraphMode; }
    }


    public void Proceed(ref byte[] array, params string[] args)
    {
        int lStr = Convert.ToInt32(args[0]);
        mainForm.setStartData(ref array);
       
    }

    public void Run(IHost host)
    {

        Application.EnableVisualStyles();
        //mainForm.Dock = DockStyle.Fill;
        mainForm.TopLevel = false;
        mainForm.Show();
        host.AddControlToMainForm(mainForm.mainPanel);

        ToolStripMenuItem options = new ToolStripMenuItem("Опции");
        options.Image = BinaryStructureModuleGraph.Resource.Options;


        ToolStripMenuItem modeSwitcher = new ToolStripMenuItem("Переключить режим: Графический");
        modeSwitcher.Image = BinaryStructureModuleGraph.Resource.GraphMode;
        modeSwitcher.Click += SwitchMode_Click;
       

        ToolStripMenuItem periodMenu = new ToolStripMenuItem("Период строки");
        periodMenu.Image = BinaryStructureModuleGraph.Resource.Period;
        periodMenu.Click += ConfigurePeriod_Click;


        ToolStripMenuItem sizeMenu = new ToolStripMenuItem("Размеры");
        sizeMenu.Image = BinaryStructureModuleGraph.Resource.size;

        ToolStripMenuItem plusSize = new ToolStripMenuItem("Увеличить размер");
        plusSize.Image = BinaryStructureModuleGraph.Resource.PlusSize;
        plusSize.Click += PlusSize_Click;

        ToolStripMenuItem minusSize = new ToolStripMenuItem("Уменьшить размер");
        minusSize.Image = BinaryStructureModuleGraph.Resource.MinusSize;
        minusSize.Click += MinusSize_Click;

        sizeMenu.DropDownItems.Add(plusSize);
        sizeMenu.DropDownItems.Add(minusSize);


        ToolStripMenuItem syncGroup = new ToolStripMenuItem("Синхрокомбинация");
        syncGroup.Image = BinaryStructureModuleGraph.Resource.SyncGroup;
        syncGroup.Click += ConfigureSyncGroup_Click;


        ToolStripMenuItem filtersMenu = new ToolStripMenuItem("Фильтрация");
        filtersMenu.Image = BinaryStructureModuleGraph.Resource.Filter;

        ToolStripMenuItem configureFilter = new ToolStripMenuItem("Конфигуратор старт-стоповых комбинаций");
        configureFilter.Click += ConfigureFilter_Click;
        configureFilter.Image = BinaryStructureModuleGraph.Resource.settings_wizard_icon;


        ToolStripMenuItem filter10st8 = new ToolStripMenuItem("Обработка 10ст8");
        filter10st8.Click += Filter10st8_Click;
        filter10st8.Image = BinaryStructureModuleGraph.Resource._10_8;

        ToolStripMenuItem filter11st8 = new ToolStripMenuItem("Обработка 11ст8");
        filter11st8.Click += Filter11st8_Click;
        filter11st8.Image = BinaryStructureModuleGraph.Resource._11;

        ToolStripMenuItem filter9st7 = new ToolStripMenuItem("Обработка 9ст7");
        filter9st7.Click += Filter9st7_Click;
        filter9st7.Image = BinaryStructureModuleGraph.Resource._9_7;


        ToolStripMenuItem configureFrameSync = new ToolStripMenuItem("Конфигуратор кадровой синхронизации");
        configureFrameSync.Image = BinaryStructureModuleGraph.Resource.frameSyncConfigure;
        configureFrameSync.Click += ConfigureFrameSync_Click;

        ToolStripMenuItem frameSync = new ToolStripMenuItem("Кадровая синхронизация");
        frameSync.Click += FrameSync_Click;
        frameSync.Image = BinaryStructureModuleGraph.Resource.FrameSync;

        ToolStripMenuItem cutData = new ToolStripMenuItem("Конфигуратор усечения");
        cutData.Image = BinaryStructureModuleGraph.Resource.Cut;
        cutData.Click += Configure_Cut_Data;

        ToolStripMenuItem reset = new ToolStripMenuItem("Сброс");
        reset.Click += Reset_Click;
        reset.Image = BinaryStructureModuleGraph.Resource.reset;

        ToolStripMenuItem stream = new ToolStripMenuItem("Поток");
        stream.Image = BinaryStructureModuleGraph.Resource.Stream;

        ToolStripMenuItem ConfigureAndSaveToText = new ToolStripMenuItem("Перевести в текст и сохранить...");
        ConfigureAndSaveToText.Image = BinaryStructureModuleGraph.Resource.TextConfigure;
        ConfigureAndSaveToText.Click += ConfigureTranslateToText_Click;

        ToolStripMenuItem SaveToText = new ToolStripMenuItem("Сохранить поток в файл...");
        SaveToText.Image = BinaryStructureModuleGraph.Resource.Save;
        SaveToText.Click += SaveToFile_Click;

        stream.DropDownItems.Add(SaveToText);
        stream.DropDownItems.Add(ConfigureAndSaveToText);

        filtersMenu.DropDownItems.Add(configureFilter);
        filtersMenu.DropDownItems.Add(new ToolStripSeparator());
        filtersMenu.DropDownItems.Add(filter10st8);
        filtersMenu.DropDownItems.Add(filter11st8);
        filtersMenu.DropDownItems.Add(filter9st7);
        filtersMenu.DropDownItems.Add(new ToolStripSeparator());
        filtersMenu.DropDownItems.Add(configureFrameSync);
        filtersMenu.DropDownItems.Add(frameSync);
        filtersMenu.DropDownItems.Add(new ToolStripSeparator());
        filtersMenu.DropDownItems.Add(cutData);
        filtersMenu.DropDownItems.Add(reset);


        options.DropDownItems.Add(modeSwitcher);
        options.DropDownItems.Add(filtersMenu);
        options.DropDownItems.Add(periodMenu);
        //options.DropDownItems.Add(syncGroup);
        options.DropDownItems.Add(sizeMenu);


        host.AddNewMenuStripToMainForm(options);
        host.AddNewMenuStripToMainForm(stream);

        Form form = (Form)host;
        form.Controls.Find("modulesTabControl", true)[0].KeyDown += mainForm.keyDown;

    }



    private void SaveToFile_Click(object sender, EventArgs e)
    {
        mainForm.SaveStreamToFile();
    }

    private void ConfigureTranslateToText_Click(object sender, EventArgs e)
    {
        mainForm.ConfigureTranslateToText();
    }

    private void ConfigureSyncGroup_Click(object sender, EventArgs e)
    {
        mainForm.ConfigureSyncMarker();
    }

    private void PlusSize_Click(object sender, EventArgs e)
    {
        mainForm.PlusSize();
    }

    private void MinusSize_Click(object sender, EventArgs e)
    {
        mainForm.MinusSize();
    }

    private void SwitchMode_Click(object sender, EventArgs e)
    {
        bool current_mode = mainForm.changeMode();
        ToolStripMenuItem mode = (ToolStripMenuItem)sender;
        switch (current_mode)
        {
            case true:
                mode.Image = BinaryStructureModuleGraph.Resource.GraphMode;
                mode.Text = "Переключить режим: Графический";
                break;
            case false:
                mode.Image = BinaryStructureModuleGraph.Resource.TextMode;
                mode.Text = "Переключить режим: Текстовый";
                break;
            default:
                break;
        }
    }

    private void ConfigureFrameSync_Click(object sender, EventArgs e)
    {
        mainForm.ConfigureFrameSync();
    }

    private void ConfigurePeriod_Click(object sender, EventArgs e)
    {
        mainForm.setPeriod();
    }

    private void ConfigureFilter_Click(object sender, EventArgs e)
    {
        mainForm.ConfigureCustomFilter();
    }

    private void Reset_Click(object sender, EventArgs e)
    {
        mainForm.Reset();
    }

    private void FrameSync_Click(object sender, EventArgs e)
    {
        mainForm.FrameSync();
    }

    private void Filter9st7_Click(object sender, EventArgs e)
    {
        mainForm.Filter9st7();
    }

    private void Filter11st8_Click(object sender, EventArgs e)
    {
        mainForm.Filter11st8();
    }

    private void Filter10st8_Click(object sender, EventArgs e)
    {
        mainForm.Filter10st8();
    }

    private void Configure_Cut_Data(object sender, EventArgs e)
    {
        mainForm.Configure_Cut_Data();
    }

    public void LoadSubModule(Control subModule, string target)
    {
        throw new NotSupportedSubModulesException();
    }
}

