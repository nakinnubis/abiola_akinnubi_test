﻿using System;
using System.Collections.Generic;

namespace LeastRecentlyUsedCache
{
    public class LatLong
    {
        public decimal Lat { get; set; }
        public decimal Long { get; set; }
    }
    public class LRUCache
    {

        /*
         Implementation of lru cache using doubly linked list
        */
        public class DNode
        {
            public int key;
            public int value;
            public IEnumerable<LatLong> LatLongs { get; set; }
            public DNode prev;
            public DNode next;
        }
        //The dictionary data structure is used to mimick hastbale
        private Dictionary<int, DNode> hashtable = new Dictionary<int, DNode>();
        private DNode head, tail;
        private int totalItemsInCache;
        private int maxCapacity;
        /// <summary>
        /// Lru cache where you set the maximum capacity
        /// it doesn't return anything but to set the maximum size of the cache
        /// </summary>
        /// <param name="maxCapacity"></param>
        public LRUCache(int maxCapacity)
        {

            // Cache starts empty and capacity is set by client
            totalItemsInCache = 0;
            this.maxCapacity = maxCapacity;

            // Initialize the dummy head of the cache
            head = new DNode();
            head.prev = null;

            // Init the dummy tail of the cache
            tail = new DNode();
            tail.next = null;

            // Wire the head and tail together
            head.next = tail;
            tail.prev = head;
        }

        /*
          Retrieve an item from the cache
          it also return the integer value of the cache
        */
        public int get(int key)
        {

            DNode node = hashtable[key];
            bool itemFoundInCache = node != null;

            // Empty state check. Should raise exception here.
            if (!itemFoundInCache)
            {
                return -1;
            }

            // Item has been accessed. Move to the front of the list.
            moveToHead(node);

            return node.value;
        }

        /*
          Add an item to the cache if it is not already there,
          if it is already there update the value and move it
          to the front of the cache
        */
        public void put(int key, int value)
        {
            //DNode v;
            hashtable.TryGetValue(key, out DNode v);
            DNode node = v;
            bool itemFoundInCache = node != null;

            if (!itemFoundInCache)
            {

                // Create a new node
                DNode newNode = new DNode();
                newNode.key = key;
                newNode.value = value;

                // Add to the hashtable and the doubly linked list
                hashtable[key] = newNode;
                addNode(newNode);

                //Just added an item to the cache
                totalItemsInCache++;

                // If over capacity evict an item with LRU cache eviction policy
                if (totalItemsInCache > maxCapacity)
                {
                    removeLRUEntryFromStructure();
                }

            }
            else
            {
                // If item is in cache just update and move it to the head
                node.value = value;
                moveToHead(node);
            }

        }

        /*
          Remove the least used entry from the doubly linked
          list as well as the hashtable. Hence it is evicted
          from the whole LRUCache structure
        */
        private void removeLRUEntryFromStructure()
        {
            DNode tail = popTail();
            hashtable.Remove(tail.key);
            --totalItemsInCache;
        }

        /*
          Insertions to the doubly linked list will always
          be right after the dummy head
        */
        private void addNode(DNode node)
        {

            // Wire the node being inserted
            node.prev = head;
            node.next = head.next;

            // Re-wire the head's old next
            head.next.prev = node;

            // Re-wire the head to point to the inserted node
            head.next = node;
        }

        /*
          Remove the given node from the doubly linked list
        */
        private void removeNode(DNode node)
        {

            // Grab reference to the prev and next of the node
            DNode savedPrev = node.prev;
            DNode savedNext = node.next;

            // Cut out going forwards
            savedPrev.next = savedNext;

            // Cut out going backards
            savedNext.prev = savedPrev;
        }

        /*
          Move a node to the head of the doubly linked lsit
        */
        private void moveToHead(DNode node)
        {
            removeNode(node);
            addNode(node);
        }

        /*
          Pop the last item from the structure
        */
        private DNode popTail()
        {
            DNode itemBeingRemoved = tail.prev;
            removeNode(itemBeingRemoved);
            return itemBeingRemoved;
        }

    }
}
