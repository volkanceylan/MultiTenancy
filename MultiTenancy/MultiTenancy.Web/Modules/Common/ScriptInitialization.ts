/// <reference path="../Common/Helpers/LanguageList.ts" />

namespace MultiTenancy.ScriptInitialization {
    Q.Config.responsiveDialogs = true;
    Q.Config.rootNamespaces.push('MultiTenancy');
    Serenity.EntityDialog.defaultLanguageList = LanguageList.getValue;
}