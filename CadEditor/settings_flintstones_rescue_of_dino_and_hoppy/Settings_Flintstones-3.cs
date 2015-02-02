using CadEditor;
using System.Collections.Generic;
//css_include Settings_Flintstones-Utils.cs;
public class Data
{ 
  public OffsetRec getScreensOffset()     { return new OffsetRec(0x122BF, 1 , 8*96);   }
  public int getScreenWidth()             { return 8; }
  public int getScreenHeight()            { return 96; }
  public bool getScreenVertical()         { return true; }
  public string getBlocksFilename()       { return "flintstones_3.png"; }
  
  public bool isBigBlockEditorEnabled() { return false; }
  public bool isBlockEditorEnabled()    { return false; }
  public bool isEnemyEditorEnabled()    { return true; }
  
  public GetObjectsFunc getObjectsFunc()   { return FliUtils.getObjects;  }
  public SetObjectsFunc setObjectsFunc()   { return FliUtils.setObjects;  }
  public GetLayoutFunc getLayoutFunc()     { return FliUtils.getLayout;   }
  public GetObjectDictionaryFunc getObjectDictionaryFunc() { return FliUtils.getObjectDictionary; }
  
  public IList<LevelRec> getLevelRecs() { return levelRecs; }
  public IList<LevelRec> levelRecs = new List<LevelRec>() 
  {
    new LevelRec(0x114E3, 42, 1, 1, 0x0),
  };
}