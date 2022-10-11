﻿using Cameca.CustomAnalysis.Interface;
using Cameca.CustomAnalysis.Utilities;
using Cameca.CustomAnalysis.Utilities.Legacy;
using Prism.Events;
using Prism.Services.Dialogs;

namespace CustomAnalysisTemplate.Core;

internal class CustomAnalysisTemplateNodeMenuFactory : AnalysisMenuFactoryBase
{
    public CustomAnalysisTemplateNodeMenuFactory(IEventAggregator eventAggregator)
        : base(eventAggregator)
    {
    }

    protected override INodeDisplayInfo DisplayInfo => CustomAnalysisTemplateNode.DisplayInfo;
    protected override string NodeUniqueId => CustomAnalysisTemplateNode.UniqueId;
    public override AnalysisMenuLocation Location { get; } = AnalysisMenuLocation.Analysis;
}