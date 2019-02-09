using CadEditor;
using System.Collections.Generic;
//css_include shared_settings/SharedUtils.cs;
//css_include banana_prince/BananaUtils.cs;

public class Data
{ 
  public OffsetRec getScreensOffset()     { return new OffsetRec(0x679A,10, 64, 8, 8);   } 
  
  public bool isBigBlockEditorEnabled() { return true; }
  public bool isBlockEditorEnabled()    { return false; }
  public bool isEnemyEditorEnabled()    { return false; }
  
  public GetVideoPageAddrFunc getVideoPageAddrFunc() { return SharedUtils.fakeVideoAddr(); }
  public GetVideoChunkFunc    getVideoChunkFunc()    { return SharedUtils.getVideoChunk(new[] {"chr3c.bin"}); }
  public SetVideoChunkFunc    setVideoChunkFunc()    { return null; }
  
  public OffsetRec getBlocksOffset()    { return new OffsetRec(0, 1 , 0x1000);  }
  public int getBlocksCount()           { return 64; }
  
  public GetBigBlocksFunc     getBigBlocksFunc() { return BananaUtils.getBigBlocks;}
  public SetBigBlocksFunc     setBigBlocksFunc() { return BananaUtils.setBigBlocks;}
  public GetBlocksFunc        getBlocksFunc() { return BananaUtils.getBlocksConsts;}
  public SetBlocksFunc        setBlocksFunc() { return null;}
  public GetPalFunc           getPalFunc()           { return SharedUtils.readPalFromBin(new[] {"pal3c.bin"}); }
  public SetPalFunc           setPalFunc()    { return null;}
  
  public OffsetRec getBigBlocksOffset() { return new OffsetRec(0x6a1a, 1 , 0x4000); }
  public int getPalBytesAddr()          { return 0x6a1a + getBigBlocksCount()*4; }
  public int getBigBlocksCount() { return 194; }
}