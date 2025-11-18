using Xunit;
using DataStructuresAndAlgorithms.DataStructures;

namespace Tests;

public class StaticArrayTests
{
    // ───────────────────────────────
    // GET() TESTS
    // ───────────────────────────────

    [Fact]
    public void Get_ReturnsCorrectValue()
    {
        var arr = new StaticArray<int>(5);
        arr.Append(10);
        arr.Append(20);

        Assert.Equal(10, arr.Get(0));
        Assert.Equal(20, arr.Get(1));
    }

    [Fact]
    public void Get_NegativeIndex_Throws()
    {
        var arr = new StaticArray<int>(5);
        Assert.Throws<IndexOutOfRangeException>(() => arr.Get(-1));
    }

    [Fact]
    public void Get_IndexGreaterThanLength_Throws()
    {
        var arr = new StaticArray<int>(5);
        arr.Append(10);

        Assert.Throws<IndexOutOfRangeException>(() => arr.Get(1));
    }


    // ───────────────────────────────
    // SET() TESTS
    // ───────────────────────────────

    [Fact]
    public void Set_AssignsValueAndIncrementsLength()
    {
        var arr = new StaticArray<int>(5);

        arr.Set(0, 10);

        Assert.Equal(1, arr.Length);
        Assert.Equal(10, arr.Get(0));
    }

    [Fact]
    public void Set_Overwrite_DoesNotIncreaseLength()
    {
        var arr = new StaticArray<int>(5);

        arr.Set(0, 10);
        arr.Set(0, 20);

        Assert.Equal(1, arr.Length);
        Assert.Equal(20, arr.Get(0));
    }

    [Fact]
    public void Set_IndexBeyondCurrentLength_Throws()
    {
        var arr = new StaticArray<int>(5);

        Assert.Throws<IndexOutOfRangeException>(() => arr.Set(2, 10)); // _count=0, valid next is 0 only
    }

    [Fact]
    public void Set_IndexBeyondCapacity_Throws()
    {
        var arr = new StaticArray<int>(3);

        Assert.Throws<IndexOutOfRangeException>(() => arr.Set(5, 50));
    }


    // ───────────────────────────────
    // APPEND() TESTS
    // ───────────────────────────────

    [Fact]
    public void Append_AddsValuesInSequence()
    {
        var arr = new StaticArray<int>(5);

        arr.Append(1);
        arr.Append(2);
        arr.Append(3);

        Assert.Equal(3, arr.Length);
        Assert.Equal(1, arr.Get(0));
        Assert.Equal(2, arr.Get(1));
        Assert.Equal(3, arr.Get(2));
    }

    [Fact]
    public void Append_WhenFull_TriggersResizeAndPreservesValues()
    {
        var arr = new StaticArray<int>(2);

        arr.Append(10);
        arr.Append(20);
        arr.Append(30); // triggers resize to 4

        Assert.Equal(3, arr.Length);
        Assert.True(arr.Capacity >= 4);
        Assert.Equal(10, arr.Get(0));
        Assert.Equal(20, arr.Get(1));
        Assert.Equal(30, arr.Get(2));
    }


    // ───────────────────────────────
    // REMOVEAT() TESTS
    // ───────────────────────────────

    [Fact]
    public void RemoveAt_RemovesLastElement()
    {
        var arr = new StaticArray<int>(5);
        arr.Append(1);
        arr.Append(2);
        arr.Append(3);

        arr.RemoveAt(2);

        Assert.Equal(2, arr.Length);
        Assert.Throws<IndexOutOfRangeException>(() => arr.Get(2));
    }

    [Fact]
    public void RemoveAt_RemovesMiddleAndShiftsLeft()
    {
        var arr = new StaticArray<int>(5);
        arr.Append(10);
        arr.Append(20);
        arr.Append(30);
        arr.Append(40);

        arr.RemoveAt(1); // remove 20

        Assert.Equal(3, arr.Length);
        Assert.Equal(10, arr.Get(0));
        Assert.Equal(30, arr.Get(1));
        Assert.Equal(40, arr.Get(2));
    }

    [Fact]
    public void RemoveAt_InvalidIndex_Throws()
    {
        var arr = new StaticArray<int>(5);
        arr.Append(10);

        Assert.Throws<IndexOutOfRangeException>(() => arr.RemoveAt(-1));
        Assert.Throws<IndexOutOfRangeException>(() => arr.RemoveAt(5));
    }


    // ───────────────────────────────
    // TOSTRING() TEST
    // ───────────────────────────────

    [Fact]
    public void ToString_PrintsOnlyAssignedValues()
    {
        var arr = new StaticArray<int>(5);
        arr.Append(1);
        arr.Append(2);
        arr.Append(3);

        Assert.Equal("[1, 2, 3]", arr.ToString());
    }
}
